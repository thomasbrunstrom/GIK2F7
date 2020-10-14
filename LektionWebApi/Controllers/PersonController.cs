using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LektionWebApi.Models;
using LektionWebApi.Repositorys;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LektionWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository pr;
        private readonly IWebHostEnvironment env;
        public PersonController(IPersonRepository repo, IWebHostEnvironment env)
        {
            this.env = env;
            pr = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> Get()
        {
            var persons = await pr.Get();
            return persons;
        }
        [HttpGet("{id}")]
        public async Task<Person> GetPerson(int id)
        {
            return await pr.Get(id);
        }

        [HttpPost]
        public async Task<Person> Add(AddPerson newPerson)
        {
            return await pr.Add(newPerson);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await pr.Delete(100);
        }

        [HttpPost("/img")]
        public async Task<Person> AddPersonImage([FromForm] PostPersonImage personImage)
        {
            Person exPerson = await pr.Get(personImage.Id);
            
            var file = personImage.postImage;
            var ext = Path.GetExtension(file.FileName).Replace(".", string.Empty);
            string fName = exPerson.Id + "." + ext;

            string path = Path.Combine(env.ContentRootPath, "Uploads\\" + fName);
            using(var stream = new FileStream(path, FileMode.OpenOrCreate)) 
            {
                await file.CopyToAsync(stream);
            }

            string url = "Uploads\\" + fName;
            exPerson.Image = url;
            await pr.Update(exPerson);
            return exPerson;            
        }
        [HttpGet("/img/{id}")]
        public async Task<IActionResult> GetImage(int id)
        {
            Person person = await pr.Get(id);
            if(person == null) 
            {
                throw new ArgumentException("Felaktigt id");
            }
            if(person.Image == null) 
            {
                throw new ArgumentException("Användaren har ingen bild");
            }
            var imgSrc = Path.Combine(env.ContentRootPath, person.Image);
            if(System.IO.File.Exists(imgSrc)) 
            {
                return PhysicalFile(imgSrc, "image/png");
            }
            else {
                throw new ArgumentException("File not found or wrong file type");
            }
        }

    }
}

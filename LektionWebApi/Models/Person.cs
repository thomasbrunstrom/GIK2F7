using System;
using Microsoft.AspNetCore.Http;

namespace LektionWebApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Image { get; set; }
    }

    public class AddPerson : Person
    {
        private new int Id { get; set; }
    }

    public class PostPersonImage
    {
        public int Id { get; set; }
        public IFormFile postImage { get; set; }
    }
}

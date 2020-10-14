using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LektionWebApi.Models;

namespace LektionWebApi.Repositorys
{
    public interface IPersonRepository
    {
        Task<Person> Add(Person person);
        Task<IEnumerable<Person>> Get();
        Task<Person> Get(int Id);
        Task<Person> Update(Person person);
        Task<bool> Delete(int Id);
        Task<bool> Delete(string name);
    }
}

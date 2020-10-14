using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using LektionWebApi.Database;
using LektionWebApi.Models;
using Microsoft.Data.Sqlite;

namespace LektionWebApi.Repositorys
{
    public class PersonRespository : IPersonRepository
    {
        private readonly DatabaseConfig databaseConfig;
        private List<Person> people;
        public PersonRespository(DatabaseConfig dbConfig)
        {
            databaseConfig = dbConfig;

            people = new List<Person> {
                new Person() { FirstName = "Thomas", Id = 1 },
                new Person() { FirstName = "Simon", Id = 2 },
                new Person() { FirstName = "Linus", Id = 3 }
            };
        }
        public async Task<Person> Add(Person person)
        {
            using(var connection = new SqliteConnection(databaseConfig.Name))
            {
                var res = await connection.ExecuteAsync("INSERT INTO Persons (FirstName, LastName) VALUES (@FirstName, @LastName)", person);
                var lastInsert = await connection.QueryAsync<Person>("SELECT Id, FirstName, LastName, Image FROM Persons ORDER BY Id DESC");
                return new Person() {
                     FirstName = person.FirstName,
                     LastName = person.LastName,
                     Id = lastInsert.FirstOrDefault<Person>().Id
                };
            }
        }

        public async Task<bool> Delete(int Id)
        {
            using(var connection = new SqliteConnection(databaseConfig.Name))
            {
                var res = await connection.ExecuteAsync("DELETE FROM Persons WHERE Id=@Id", new { Id });
                if(res > -1) 
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }
        public async Task<bool> Delete(string Name)
        {
            using(var connection = new SqliteConnection(databaseConfig.Name))
            {
                var res = await connection.ExecuteAsync("DELETE FROM Persons WHERE FirstName=@Name", new { Name });
                if(res > -1) 
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }

        public async Task<IEnumerable<Person>> Get()
        {
            using(var con = new SqliteConnection(databaseConfig.Name))
            {
                var res = await con.QueryAsync<Person>("SELECT Id, FirstName, LastName, Image FROM Persons ORDER BY FirstName ASC");
                return res;
            }
        }

        public async Task<Person> Get(int Id)
        {
            using(var con = new SqliteConnection(databaseConfig.Name))
            {
                var res = await con.QueryAsync<Person>("SELECT Id, FirstName, LastName, Image FROM Persons WHERE Id=@Id", new { Id });
                return res.FirstOrDefault<Person>();
            }
        }

        public async Task<Person> Update(Person person)
        {
            using(var con = new SqliteConnection(databaseConfig.Name))
            {
                var res = await con.ExecuteAsync("UPDATE Persons SET FirstName=@FirstName, LastName=@LastName, Image=@Image WHERE Id=@Id", person);
                return person;
            }
        }
    }
}

using System;
using System.IO;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;

namespace LektionWebApi.Database
{
    public class DatabaseBootstrap : IDatabaseBootstrap
    {
        private DatabaseConfig databaseConfig;
        public DatabaseBootstrap(DatabaseConfig dbConfig)
        {
            databaseConfig = dbConfig;
        }
        public void Setup()
        {
            using(SqliteConnection connection = new SqliteConnection(databaseConfig.Name))
            {
                var table = connection.Query<string>("SELECT Name FROM sqlite_master WHERE type='table' AND name='Persons'");
                var tableName = table.FirstOrDefault();
                if(!string.IsNullOrEmpty(tableName) && tableName == "Persons")
                {
                    return;
                }
                using(var sr = new StreamReader(databaseConfig.StructureFile))
                {
                    var queries = sr.ReadToEnd();
                    connection.Execute(queries);
                }
            }
        }
    }
}

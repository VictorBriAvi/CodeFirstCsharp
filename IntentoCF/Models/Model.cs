using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntentoCF.Models
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = LAPTOP-622ROEGK\SQLEXPRESS; DataBase = CodeFirst; Trusted_Connection=True;");
        }
        public DbSet<People> People { get; set; }
        public DbSet<House> House { get; set; }


    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<House> House { get; set; }
    }

    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int PeopleId { get; set; }
        public People People { get; set; }
    }
}

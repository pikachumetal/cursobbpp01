using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIDI.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MedysifDBEntities") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
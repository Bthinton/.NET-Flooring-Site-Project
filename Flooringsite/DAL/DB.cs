using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flooringsite.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Flooringsite.DAL
{
    public class DB : DbContext
    {
        public DB() : base("DB")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
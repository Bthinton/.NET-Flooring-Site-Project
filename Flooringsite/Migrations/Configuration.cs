namespace Flooringsite.Migrations
{
    using Flooringsite.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Flooringsite.DAL.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Flooringsite.DAL.DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(p => p.Customer_Id,
            new Customer() { Customer_Id = 1, FirstName = "Lee", LastName = "Puckett", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 2, FirstName = "Michael", LastName = "Brown", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 3, FirstName = "Elizabeth", LastName = "Gray", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 4, FirstName = "Irene", LastName = "Click", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 5, FirstName = "Lauren", LastName = "Wright", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 6, FirstName = "Chuck", LastName = "Winters", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 7, FirstName = "Amit", LastName = "Bania", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 8, FirstName = "Brad", LastName = "Hinton", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 9, FirstName = "Juanita", LastName = "Von Dwingelo", CustomerEmail = "", ContactNumber = "", },
            new Customer() { Customer_Id = 0, FirstName = "Peter", LastName = "Nelson", CustomerEmail = "", ContactNumber = "", }
            );
        }
    }
}

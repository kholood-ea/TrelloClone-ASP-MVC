namespace TrelloClone.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TrelloClone.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<TrelloClone.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrelloClone.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AddUser(context);
        }

        // ** adding a seed to test upon 
        public void AddUser(TrelloClone.Models.ApplicationDbContext context)
        { var user = new ApplicationUser {UserName="admin@admin.com"};
            var um = new UserManager<ApplicationUser>
                (new UserStore<ApplicationUser>(context));
            um.Create(user, "password"); 
        }
    }
}

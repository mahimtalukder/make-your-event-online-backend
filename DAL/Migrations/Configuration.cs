namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Xml.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.OrganizeYourEventContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(DAL.EF.OrganizeYourEventContext context)
        {
            List<ActionList> list = new List<ActionList>();

            list.Add(new ActionList()
            {
                Id = 1,
                Name = "AdminLogin",

            });

            context.ActionLists.AddOrUpdate(list.ToArray());

        }

        protected override void Seed(DAL.EF.OrganizeYourEventContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data

        }
    }
}

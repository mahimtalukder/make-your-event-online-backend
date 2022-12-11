﻿namespace DAL.Migrations
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

            string[] actions = new string[] { "AdminLogin","CustomerLogin","OrganizationLogin","CreateAdmin", "CreateCUstomer","CreateOrganization","EditAdmin","EditCostomer","EditOrganization","DeleteAdmin","deleteCostomer","DeleteOrganization" };

            for (int i = 0; i <= actions.Length - 1; i++)
            {
                list.Add(new ActionList()
                {
                    Name = actions[i]
                });
            }

            context.ActionLists.AddOrUpdate(list.ToArray());

        }


    }
}

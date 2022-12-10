using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Admin, int, Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }
        public static IRepo<ActionList, int, ActionList> ActionListDataAccess()
        {
            return new ActionListRepo();
        }

        public static IRepo<Organizer, int, Organizer> OrganizerDataAccess()
        {
            return new OrganizerRepo();
        }

        public static IRepo<OrganizingArea, int, OrganizingArea> OrganizingAreaDataAccess()
        {
            return new OrganizingAreaRepo();
        }

        public static IRepo<Location, int, Location> LocationDataAccess()
        {
            return new LocationRepo();
        }

        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
    }
}

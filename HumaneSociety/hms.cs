using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        private static HumaineSocietyDataContext database = new HumaineSocietyDataContext();

        internal static void RunEmployeeQueries(Employee employee, string v)
        {
            throw new NotImplementedException();
        }

        internal static Client GetClient(string userName, string password)
        {
            throw new NotImplementedException();
        }

        internal static object GetUserAdoptionStatus(Client client)
        {
            throw new NotImplementedException();
        }

        internal static object RetrieveClients()
        {
            throw new NotImplementedException();
        }

        internal static object GetAnimalByID(int iD)
        {
            throw new NotImplementedException();
        }

        internal static void Adopt(object animal, Client client)
        {
            throw new NotImplementedException();
        }

        internal static IQueryable<USState> GetStates()
        {
            var requiredData = from x in database.USStates
                               select x;
            return requiredData;
        
    }

        internal static void updateClient(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateUsername(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateEmail(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateFirstName(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAddress(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateLastName(Client client)
        {
            throw new NotImplementedException();
        }

        internal static object SearchForAnimalByMultipleTraits()
        {
            throw new NotImplementedException();
        }
    }
}

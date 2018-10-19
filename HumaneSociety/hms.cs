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

        public static Client GetClient(string userName, string password)
        {//100
            var requiredData = (from x in database.Clients
                                where x.UserName == userName && x.Password == password
                                select x).FirstOrDefault();

            return requiredData;
        }

        public static IQueryable<Adoption> GetUserAdoptionStatus(Client client)
        {
            //100
            var clientAdoptions = database.Adoptions.Where(a => a.ClientId == client.ClientId);
            return clientAdoptions;
            
        }


        internal static IQueryable<Client> RetrieveClients()
        {//100
            var requiredData = from x in database.Clients select x;
            return requiredData;
        }

        public static IQueryable<Animal> GetAnimalByID(int iD)
        {//100

            var requiredData =
                (from x in database.Animals
                 where x.AnimalId == iD
                 select x);
            return requiredData;
        }

        internal static void Adopt(object animal, Client client)
        {
            throw new NotImplementedException();
        }

        internal static IQueryable<USState> GetStates()
        {//100
            var requiredData = from x in database.USStates
                               select x;
            return requiredData;
        
        }
        public static Client updateClient (Client client)
        {//100
            var requiredData = (from x in database.Clients
                                where x.ClientId ==client.ClientId
                                select x).First();
            
            database.Clients.InsertOnSubmit(requiredData);
            return requiredData;

        }
       

        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
           
        }

        public static void UpdateUsername(Client client)
        {//100
            var requiredData = (from x in database.Clients
                                where x.ClientId == client.ClientId
                                select x).First();

            requiredData.UserName = client.UserName;
            database.Clients.InsertOnSubmit(requiredData);
            database.SubmitChanges();
        }

        public static void UpdateEmail(Client client)
        {
            var requiredData = (from x in database.Clients
                                where x.ClientId== client.ClientId
                                select x).First();
           // requiredData = UpdateEmail;
        }

        internal static void UpdateFirstName(Client client)
        {
            throw new NotImplementedException();
        }

        internal static object GetPendingAdoptions()
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

        internal static void UpdateShot(string v, Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static object GetShots(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAnimal(object animal)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAdoption(bool v, Adoption adoption)
        {
            throw new NotImplementedException();
        }

        internal static Room GetRoom(int animalId)
        {
            throw new NotImplementedException();
        }
    }
}

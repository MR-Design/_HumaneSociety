using System;
using System.Collections.Generic;
using System.Linq;

namespace HumaneSociety
{
    public static class Query
    {
        private static HumaineSocietyDataContext database = new HumaineSocietyDataContext();
        internal static IQueryable<USState> GetStates()
        {//100
            var requiredData = from x in database.USStates
                               select x;
            return requiredData;

        }
        public static void UpdateAddress(Client client)
        {
            var requiredData = (from x in database.Clients
                                where x.ClientId == client.ClientId
                                select x).First();
            requiredData.Address = client.Address;

            database.SubmitChanges();
        }

        public static void UpdateLastName(Client client)
        {
            var requiredData = (from x in database.Clients
                                where x.ClientId == client.ClientId
                                select x).First();
            requiredData.LastName = client.LastName;

            database.SubmitChanges();
        }
        public static void RemoveAnimal(Animal animal)
        {
            var animalToRemove = database.Animals.Where(a => a.AnimalId == animal.AnimalId).FirstOrDefault();
            database.Animals.DeleteOnSubmit(animalToRemove);
            database.SubmitChanges();
        }
        public static void UpdateAdoption(bool isApproved, Adoption adoption)
        {
            var adoptionToUpdate = database.Adoptions.Where(a => a.AdoptionId == adoption.AdoptionId).FirstOrDefault();
            if (isApproved)
            {
                adoptionToUpdate.ApprovalStatus = "Approved";

            }
            else
                adoptionToUpdate.ApprovalStatus = " Not Approved";
        }

            database.SubmitChanges();
        }

        public static Room GetRoom(int animalID)
        {
            var room = database.Rooms.Where(r => r.AnimalId == animalID).FirstOrDefault();
            return room;
        }
        public static DietPlan GetDietPlan(string planName)
        {
            var dietPlan = database.DietPlans.Where(p => p.Name == planName).FirstOrDefault();
            return dietPlan;
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

        public static void UpdateUsername(Client client)
        {//100
            var requiredData = (from x in database.Clients
                                where x.ClientId == client.ClientId
                                select x).First();

            requiredData.UserName = client.UserName;

            database.SubmitChanges();
        }

        public static void UpdateEmail(Client client)
        {
            var requiredData = (from x in database.Clients
                                where x.ClientId == client.ClientId
                                select x).First();
            requiredData.Email = client.Email;

            database.SubmitChanges();
        }

        public static void UpdateFirstName(Client client)
        {
            var requiredData = (from x in database.Clients
                                where x.ClientId == client.ClientId
                                select x).First();
            requiredData.FirstName = client.FirstName;

            database.SubmitChanges();
        }


        public static Client updateClient (Client client)
        {//100
            var requiredData = (from x in database.Clients
                                where x.ClientId ==client.ClientId
                                select x).First();
            
            database.Clients.InsertOnSubmit(requiredData);
            return requiredData;

        }
       
        public static List <Adoption> GetPendingAdoptions()//new
           {
           var PendingAdoption = database.Adoptions.ToList();
           return PendingAdoption;
           }

        public static Species GetSpecies() //New
        {
            var Sps = database.Species.Single();

            return Sps;
        }
        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
           
        }

        
        internal static void RunEmployeeQueries(Employee employee, string v)
        {
            throw new NotImplementedException();
        }

        internal static void Adopt(object animal, Client client)
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

       
    }
}

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
        public static void UpdateAdoption(bool v, Adoption adoption) //here
        {
            var animal = database.Animals.Where(x => x.AnimalId == adoption.AnimalId).FirstOrDefault();
            if (v)
            {
                animal.AdoptionStatus = "Adopted";

            }
            else
            {
                animal.AdoptionStatus = "Not Adopted";
            }
            database.SubmitChanges();
        }

        //public static void UpdateAdoption(bool isApproved, Adoption adoption)
        //{
        //    var adoptionToUpdate = database.Adoptions.Where(a => a.AdoptionId == adoption.AdoptionId).FirstOrDefault();
        //    if (isApproved)
        //    {
        //        adoptionToUpdate.ApprovalStatus = "Approved";

        //    }
        //    else
        //    { 
        //        adoptionToUpdate.ApprovalStatus = " Not Approved";
        //}
        //    database.SubmitChanges();
        //}

        public static Room GetRoom(int animalID)
        {
            var room = database.Rooms.Where(r => r.AnimalId == animalID).FirstOrDefault();
            return room;
        }

        public static DietPlan DietPlan(string planName)
        {
            var DietPlan = database.DietPlans.Where(p => p.Name == planName).FirstOrDefault();
            return DietPlan;
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


        public static Client updateClient(Client client)
        {//100
            var requiredData = (from x in database.Clients
                                where x.ClientId == client.ClientId
                                select x).First();
            requiredData = client;

            database.SubmitChanges();

            return requiredData;

        }



        public static List<Adoption> GetPendingAdoptions()//new
        {
            var PendingAdoption = database.Adoptions.ToList();
            return PendingAdoption;
        }
        public static void AddAnimal(Animal animal)////// check
        {
            var addingAnimal = database.Animals.FirstOrDefault();
            database.Animals.InsertOnSubmit(addingAnimal);
            database.SubmitChanges();
        }

        public static Species GetSpecies() //New
        {
            var Sps = database.Species.Single();

            return Sps;
        }
        internal static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            //100
            Client client = new Client();
            Address address = new Address();
            address.AddressLine1 = streetAddress;
            address.Zipcode = zipCode;
            address.USStateId = state;
            client.FirstName = firstName;
            client.LastName = lastName;
            client.UserName = username;
            client.Password = password;
            client.Email = email;
            database.Addresses.InsertOnSubmit(address);
            database.SubmitChanges();
            client.AddressId = address.AddressId;
            database.Clients.InsertOnSubmit(client);
            database.SubmitChanges();

            
        }
        internal static Employee RetrieveEmployeeUser(string email, int employeeNumber) //New
        {
            var GettingEmployee = database.Employees.Where(g => g.Email == email)
                .Where(g => g.EmployeeNumber == employeeNumber).FirstOrDefault();
            return GettingEmployee;

        }
        //public static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        //{
        //    var employee = database.Employees.Where(e => e.Email == email && e.EmployeeNumber == employeeNumber).FirstOrDefault();
        //    return employee;
        //}

        public static Employee EmployeeLogin(string userName, string password)
        {

            var employee = database.Employees.Where(e => e.UserName == userName && e.Password == password).First();
            return employee;
        }
        internal static void Adopt(IQueryable<Animal> animal, Client client) // Needs To check
        {
            Adoption NewAnimalToAdopt = new Adoption();
            NewAnimalToAdopt.AnimalId = client.ClientId;
            database.Adoptions.InsertOnSubmit(NewAnimalToAdopt);
            database.SubmitChanges();
        }
        //internal static void AddUsernameAndPassword(Employee employee)///// Not Sent Yet
        //{
        //    var AddingUserAndPass = database.Employees.Where(a => a.UserName == employee.UserName &&
        //    a.Password == employee.Password).FirstOrDefault();

        //}

        internal static void AddUsernameAndPassword(Employee employee)//not working
        {
            Console.Write("Please Chose a Password!! Case Sensitive");
            string InputPasword = Console.ReadLine();

            Console.Write("Please Chose a User Name!! ");
            var InputUserName = Console.ReadLine();

            employee.Password = InputPasword;
            employee.UserName = InputUserName;
            var AddingPasse = database.Employees.Where(a => a.UserName == employee.UserName
            && a.Password == employee.Password).FirstOrDefault();
            AddingPasse.UserName = InputUserName;
            AddingPasse.Password = InputPasword;
            database.Employees.InsertOnSubmit(AddingPasse);
        }

        public static bool CheckEmployeeUserNameExist(string username)
        {
            var existingEmployeeID = database.Employees.Where(e => e.UserName == username).Select(e => e.EmployeeId);
            if (existingEmployeeID.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public delegate void EmployeeFunction(Employee employee);
        public static void RunEmployeeQueries(Employee employee, string operation)
        {
            EmployeeFunction employeeCrudFunctions = null;
                //new EmployeeFunction(ReadEmployee);

            switch (operation)
            {
                case "create":
                    employeeCrudFunctions = CreateEmployee;
                    break;
                case "read":
                    employeeCrudFunctions = ReadEmployee;
                    break;
                case "update":
                    employeeCrudFunctions = UpdateEmployee;
                    break;
                case "delete":
                    employeeCrudFunctions = RemoveEmployee;
                    break;
            }

            employeeCrudFunctions(employee);
        }

        public static void ReadEmployee(Employee employee)
        {
            var EmployeeInfo = database.Employees.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefault();
            Console.WriteLine(EmployeeInfo.FirstName + " " + EmployeeInfo.LastName);
            Console.WriteLine("Employee #" + EmployeeInfo.EmployeeNumber);
        
         
        
            
        }

        private static void CreateEmployee(Employee employee)// creating an employee
        {

          

            database.Employees.InsertOnSubmit(employee);

            database.SubmitChanges();
        }
        private static void UpdateEmployee(Employee employee) // updating an employee
        {
            var query = database.Employees.Where(e => e.EmployeeNumber == employee.EmployeeNumber);

            foreach (Employee employeeFound in query)
            {
                employeeFound.FirstName = employee.FirstName;
                employeeFound.LastName = employee.LastName;
                employeeFound.UserName = employee.UserName;
                employeeFound.Email = employee.Email;
                employeeFound.Animals = employee.Animals;
            }
           
          
            database.SubmitChanges();
        }
        private static void RemoveEmployee(Employee employee)//deleting an employee
        {
            var query = database.Employees.Where(e => e.EmployeeNumber == employee.EmployeeNumber).FirstOrDefault();


            database.Employees.DeleteOnSubmit(query);
            database.SubmitChanges();
        }

        internal static IQueryable<Animal> SearchForAnimalByMultipleTraits()
        {
            Console.Write("Enter Animal? Name, Age ,Gender ");

            Console.Write("Enter Animal Name Please!! ");
            string NameInput = Console.ReadLine();


            Console.Write("How Old is your Animal ");
            int AgeInput = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Animal Gender!! ");
            string GenderInput = Console.ReadLine();

            var AnimalSearch = database.Animals.Where(a => a.Name == NameInput)
                .Where(a => a.Gender == GenderInput)
                .Where(a => a.Age == AgeInput);

            return AnimalSearch;
        }

        internal static void UpdateShot(string v, Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static List<AnimalShot> GetShots(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {
            throw new NotImplementedException();
        }
        
    }
}

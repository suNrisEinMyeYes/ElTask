using ElTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Data
{
    public class MockLaptopRepo : ICommandRepo
    {
        public void AddLaptop(Laptop laptop)
        {
            throw new NotImplementedException();
        }

        public void DeleteLaptop(Laptop laptop)
        {
            throw new NotImplementedException();
        }

        public Models.Laptop GetLaptopById(int Id)
        {
            return new Models.Laptop { Id = 4, Manufacturer = "Asus", Model = "AAA", Price = 1231 } ;
        }

        public LaptopRegistration GetLaptopByInvNumb(string IN)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Laptop> GetLaptops()
        {
            var Laptops = new List<Models.Laptop> {

                new Models.Laptop { Id = 0,  Manufacturer = "Asus", Model = "AAA", Price = 1231 } ,
                new Models.Laptop { Id = 1,  Manufacturer = "HP", Model = "asd", Price = 1111 } ,
                new Models.Laptop { Id = 2,  Manufacturer = "BENQ", Model = "ABC", Price = 123123 } 
            };
            return Laptops;
        }

        public void RegisterLaptop(LaptopRegistration laptopRegistration)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateLaptop(LaptopRegistration laptopRegistration)
        {
            throw new NotImplementedException();
        }

        public void UpdateLaptop(Laptop laptop)
        {
            throw new NotImplementedException();
        }
    }
}

using ElTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Data
{
    public class SqlLaptopRepo : ICommandRepo
    {
        private readonly AppContext _appContext;
        public SqlLaptopRepo(AppContext appContext)
        {
            _appContext = appContext;
        }

        public void AddLaptop(Laptop laptop)
        {
            if (laptop == null)
            {
                throw new ArgumentNullException(nameof(laptop));
            }
            _appContext.Laptops.Add(laptop);
        }

        public void DeleteLaptop(Laptop laptop)
        {
            if (laptop == null)
            {
                throw new ArgumentNullException(nameof(laptop));
            }
            var ToDel = _appContext.Lreg.FirstOrDefault(f => f.Laptop_Id == laptop.Id);
            _appContext.Lreg.Remove(ToDel);
            _appContext.Laptops.Remove(laptop);
        }

        public Laptop GetLaptopById(int Id)
        {
            return _appContext.Laptops.FirstOrDefault(p => p.Id == Id); 
        }

        public LaptopRegistration GetLaptopByInvNumb(string IN)
        {
            return _appContext.Lreg.FirstOrDefault(f => f.InventoryNumber == IN);
        }

        public IEnumerable<Laptop> GetLaptops()
        {
            return _appContext.Laptops.ToList();
        }

        public void RegisterLaptop(LaptopRegistration laptopRegistration)
        {
            if (laptopRegistration == null)
            {
                throw new ArgumentNullException(nameof(laptopRegistration));
            }
            _appContext.Lreg.Add(laptopRegistration);
        }

        public bool SaveChanges()
        {
            return (_appContext.SaveChanges() >= 0);
        }

        public void UpdateLaptop(LaptopRegistration laptopRegistration)
        {
            
        }

        public void UpdateLaptop(Laptop laptop)
        {
            
        }

        
    }
}

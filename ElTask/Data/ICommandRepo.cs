using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Data
{
    public interface ICommandRepo
    {

        bool SaveChanges();
        IEnumerable<Models.Laptop> GetLaptops();
        Models.Laptop GetLaptopById(int Id);

        void AddLaptop(Models.Laptop laptop);

        void RegisterLaptop(Models.LaptopRegistration laptopRegistration);

        void UpdateLaptop(Models.LaptopRegistration laptopRegistration);

        void UpdateLaptop(Models.Laptop laptop);

        Models.LaptopRegistration GetLaptopByInvNumb(string IN);

        void DeleteLaptop(Models.Laptop laptop);

    }
}

using ElTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Dtos
{
    public class RegisterLaptop
    {
        
        
        public int Employee_Id { get; set; }
        
        public int Laptop_Id { get; set; }

        public string InventoryNumber { get; set; }

        
        public DateTime RegistrationDate { get; set; }

        public DateTime WriteOffDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Models
{
    public class LaptopRegistration
    {
        [Key]
        public int Id { get; set; }

        public int? Employee_Id { get; set; }
        [ForeignKey("Employee_Id")]

        public Employee employee { get; set; }
        public int? Laptop_Id { get; set; }
        [ForeignKey("Laptop_Id")]
        public Laptop laptop { get; set; }

        public string InventoryNumber { get; set; }
        
        [Required]
        public DateTime RegistrationDate { get; set; }

        public DateTime WriteOffDate { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Price { get; set; }
        
        public string CPU { get; set; }
        
        public string Graphics { get; set; }
        
        public float ScreenSize { get; set; }
        
        public string StorageType { get; set; }
        
        public int StorageCapacity { get; set; }
        
        public string OS { get; set; }
        
        public int RAMsize { get; set; }
        
        [Required]
        public int DepreciationPeriod { get; set; }
        [Required]
        public DateTime StorageArrivingDate { get; set; }
        [Required]
        public string CurrentStatus { get; set; }
        
    }
}

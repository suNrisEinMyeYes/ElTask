using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Dtos
{
    public class ReadLaptops
    {

        public int Id { get; set; }
        public string Manufacturer { get; set; }
        
        public string Model { get; set; }
        
        public int Price { get; set; }
        
        public int DepreciationPeriod { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Dtos
{
    public class CreateLaptop
    {

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public DateTime StorageArrivingDate { get; set; }

        public Status CurrentStatus { get; set; }

        public int DepreciationPeriod { get; set; }


    }
}

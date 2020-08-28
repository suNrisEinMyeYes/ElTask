using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Dtos
{
    public class GetLaptopByIN
    {
        public int Employee_Id { get; set; }

        public int Laptop_Id { get; set; }

        public string InventoryNumber { get; set; }


        public DateTime RegistrationDate { get; set; }
    }
}

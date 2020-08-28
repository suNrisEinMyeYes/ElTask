using AutoMapper;
using ElTask.Dtos;
using ElTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Profiles
{

    public class LaptopsProfile : Profile
    {
        public LaptopsProfile()
        {
            CreateMap<Laptop, ReadLaptops>();
            CreateMap<CreateLaptop, Laptop>();
            CreateMap<UpdateLaptopStatus, Laptop>();
            CreateMap<UpdateLaptopOwner, LaptopRegistration>();
            CreateMap<RegisterLaptop, LaptopRegistration>();
            CreateMap<GetLaptopByIN, LaptopRegistration>();
        }
    }
}

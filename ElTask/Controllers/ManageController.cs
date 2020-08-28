using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ElTask.Data;
using ElTask.Dtos;
using ElTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageController : ControllerBase
    {
        private readonly ICommandRepo _repository;
        private readonly IMapper _mapper;

        public ManageController(ICommandRepo repo, IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }
        // GET: api/Manage
        //private MockLaptopRepo _repository = new MockLaptopRepo();
        [HttpGet]
        public ActionResult<IEnumerable<ReadLaptops>> GetAllLaptops()
        {
            var AllLaptops = _repository.GetLaptops();
            return Ok(_mapper.Map<IEnumerable<ReadLaptops>>(AllLaptops));
        }

        // GET: api/Manage/5
        [HttpGet("{id}", Name = "GetLaptopById")]
        public ActionResult<ReadLaptops> GetLaptopById(int Id)
        {
            var LaptoopById = _repository.GetLaptopById(Id);
            if (LaptoopById != null)
            {
                return Ok(_mapper.Map<ReadLaptops>(LaptoopById));
            }
            return NotFound();
        }

        [HttpGet("{invnumb}/{id}", Name = "GetLaptopByIN")]
        public ActionResult<GetLaptopByIN> GetLaptopByIN(string IN)
        {
            var LaptoopByIN = _repository.GetLaptopByInvNumb(IN);
            if (LaptoopByIN != null)
            {
                return Ok(_mapper.Map<GetLaptopByIN>(LaptoopByIN));
            }
            return NotFound();
        }

        // POST: api/Manage
        [HttpPost]
        public ActionResult<ReadLaptops> CreateLaptop(CreateLaptop createLaptop)
        {
            var LaptopModel = _mapper.Map<Laptop>(createLaptop);
            _repository.AddLaptop(LaptopModel);
            _repository.SaveChanges();

            var ReadDto = _mapper.Map<ReadLaptops>(LaptopModel);
            return CreatedAtRoute(nameof(GetLaptopById), new { Id = ReadDto.Id }, ReadDto);
            //return Ok(LaptopModel);
        }

        [HttpPost("{reg}")]
        public ActionResult<RegisterLaptop> RegisterLaptop(RegisterLaptop registerLaptop)
        {
            var LaptopModel = _mapper.Map<LaptopRegistration>(registerLaptop);
            _repository.RegisterLaptop(LaptopModel);
            _repository.SaveChanges();
            return Ok(LaptopModel);
        }

        // PUT: api/Manage/5
        [HttpPut("{ownerchange}/{id}")]
        public ActionResult UpdateOwner(string IN, UpdateLaptopOwner updateLaptopOwner)
        {
            var ModelFromRepo = _repository.GetLaptopByInvNumb(IN);
            if (ModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(updateLaptopOwner, ModelFromRepo);
            _repository.UpdateLaptop(ModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpPut("{statuschange}/{Id}")]
        public ActionResult UpdateStatus(int id, UpdateLaptopStatus updateLaptopStatus)
        {
            var ModelFromRepo = _repository.GetLaptopById(id);
            if (ModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(updateLaptopStatus, ModelFromRepo);
            _repository.UpdateLaptop(ModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }



        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult DeleteLaptop(int Id)
        {
            var LaptoopById = _repository.GetLaptopById(Id);
            if (LaptoopById == null)
            {
                return NotFound();
            }
            _repository.DeleteLaptop(LaptoopById);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using ATS.Domain.Interfaces;
using ATS.Domain.Models;
using ATS.Web.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ATS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private readonly TruckService _truckService;
        private readonly IRepository<Truck> _truckRepository;

        public TruckController(TruckService truckService,
            IRepository<Truck> truckRepository)
        {
            _truckService = truckService;
            _truckRepository = truckRepository;
        }

         [HttpGet]
         public IEnumerable<Truck> GetTrucks()
         {
             var trucks = _truckRepository.GetAll();
            
            return trucks;
        }


        [HttpGet("{id}")]
         public  ActionResult<Truck> GetTruck(int id)
         {
             var caminhao = _truckRepository.GetById(id);
             if (caminhao == null)
             {
                 return NotFound(new { message = $"Caminhão de id={id} não encontrado" });
             }
             return caminhao;
         }

        [HttpPost]
        public IActionResult Save([FromBody]Truck caminhao)
        {
            if (caminhao == null)
                return NotFound();

            _truckRepository.Save(caminhao);

            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Truck caminhao)
        {
            if (caminhao == null)
                return NotFound();

            _truckRepository.Update(caminhao);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return NotFound();

            _truckRepository.Delete(id);

            return Ok();
        }
    }
}
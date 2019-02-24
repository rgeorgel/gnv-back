using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gnv_back.Business;
using gnv_back.Models;
using Microsoft.AspNetCore.Mvc;

namespace gnv_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private IStationBusiness _stationBusiness;

        public StationController(IStationBusiness stationBusiness) {
            _stationBusiness = stationBusiness;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var stations = _stationBusiness.FindAll();
            return Ok(stations);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Station station)
        {
            if (station == null) return BadRequest();
            return new ObjectResult(_stationBusiness.Create(station));
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Station station)
        {
            if (station == null) return BadRequest();

            var updatedStation = _stationBusiness.Update(station);
            if (updatedStation == null) return NoContent();

            return new ObjectResult(updatedStation);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _stationBusiness.Delete(id);
            return NoContent();
        }
    }
}

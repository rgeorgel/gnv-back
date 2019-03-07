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
    public class NotificationController : ControllerBase
    {
        private INotificationBusiness _notificationBusiness;

        public NotificationController(INotificationBusiness notificationBusiness) {
            _notificationBusiness = notificationBusiness;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var notifications = _notificationBusiness.FindAll();
            return Ok(notifications);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Notification notification)
        {
            if (notification == null) return BadRequest();
            return new ObjectResult(_notificationBusiness.Create(notification));
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Notification notification)
        {
            if (notification == null) return BadRequest();

            var updatedNotification = _notificationBusiness.Update(notification);
            if (updatedNotification == null) return NoContent();

            return new ObjectResult(updatedNotification);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _notificationBusiness.Delete(id);
            return NoContent();
        }
    }
}

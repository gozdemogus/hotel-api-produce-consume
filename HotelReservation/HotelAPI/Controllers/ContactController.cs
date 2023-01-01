using System;
using HotelAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using UpSchool_WebApi.DAL;
using UpSchool_WebApi.DAL.Entities;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController:ControllerBase
	{
		
        Context context = new Context();


        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {
            contact.dateTime = DateTime.Now;
            context.Contacts.Add(contact);
            context.SaveChanges();
            return Ok();
        }
    }
}


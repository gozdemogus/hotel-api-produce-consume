using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UpSchool_WebApi.DAL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {

        Context context = new Context();

        // GET: api/values
        [HttpGet]
        public IActionResult GetReviews()
        {
            var values = context.Reviews.ToList();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetReviewById(int id)
        {
            var values = context.Reviews.Find(id);
            return Ok(values);
        }


        [HttpGet("/reviewbyroom/{number}")]
        public IActionResult GetReviewByRoomId(int number)
        {

            var values = context.Reviews.Where(x=>x.Room.Number == number);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult MakeAReview(Review review)
        {
            review.Date = DateTime.Now;
            var values = context.Reviews.Add(review);
            context.SaveChanges();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReview(int id)
        {
            var values = context.Reviews.Find(id);
            context.Reviews.Remove(values);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateReview(Review review)
        {
            var values = context.Reviews.Find(review.ID);
            values.Description = review.Description;
            values.Room = review.Room;
            context.SaveChanges();
            return Ok();
        }

    }
}


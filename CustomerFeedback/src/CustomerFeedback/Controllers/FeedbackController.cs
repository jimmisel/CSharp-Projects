using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CustomerFeedback.Data;
using CustomerFeedback.Models;

namespace CustomerFeedback.Models
{
    [Produces("application/json")]
    [Route("api/Feedback")]
    public class FeedbackController : Controller
    {
        private ApplicationDbContext _db;
        public FeedbackController(ApplicationDbContext db)
        {
            this._db = db;
        }
        // GET: api/Feedback
        [HttpGet]
        public IEnumerable<Feedback> Get()
        {
            //return new string[] { "value1", "value2" };
            return _db.FeedBack.ToList();
        }

        // GET: api/Feedback/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var feedBack = _db.FeedBack.FirstOrDefault(f => f.Id == id);
            if (feedBack == null)
            {
                return NotFound();
            }
            return Ok(feedBack);
        }
        
        // POST: api/Feedback
        [HttpPost]
        public IActionResult Post([FromBody]Feedback value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }
            if (value.Id == 0)
            {
                value.CreatedAt = DateTime.Now;
                //Add the feedback
                _db.FeedBack.Add(value);
                _db.SaveChanges();
            }
            else
            {
                var original = _db.FeedBack.FirstOrDefault(f => f.Id == value.Id);
                original.comment = value.comment;
                _db.SaveChanges();
            }
            return Ok(value);
        }
        
       
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var feedBack = _db.FeedBack.FirstOrDefault(f => f.Id == id);
            if (feedBack == null)
            {
                return NotFound();
            }
            _db.FeedBack.Remove(feedBack);
            _db.SaveChanges();
            return Ok();
        }
    }
}

using DataWork.Data;
using DataWork.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web_API_Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly CinemaDbContext context;

        public CinemaController(CinemaDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Sessions.ToList());
        }

        [HttpPost]
        public IActionResult Create(Session session)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Sessions.Add(session);
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();

            var session = context.Sessions.Find(id);

            if (session == null) return NotFound();

            context.Sessions.Remove(session);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(Session session)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Sessions.Update(session);
            context.SaveChanges();

            return Ok();
        }

        [HttpGet("detailsSession/{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0) return BadRequest();

            var session = context.Sessions.Find(id);

            if (session == null) return NotFound();

            return Ok(session);
        }
    }
}

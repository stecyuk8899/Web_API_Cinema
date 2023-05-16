using DataWork.Data;
using DataWork.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web_API_Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly CinemaDbContext context;
        public ActorController(CinemaDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Actors.ToList());
        }
        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Actors.Add(actor);
            context.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();

            var actor = context.Actors.Find(id);

            if (actor == null) return NotFound();

            context.Actors.Remove(actor);
            context.SaveChanges();

            return Ok();
        }
        [HttpPut]
        public IActionResult Edit(Actor Actor)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Actors.Update(Actor);
            context.SaveChanges();

            return Ok();
        }
        [HttpGet("detailsActor/{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0) return BadRequest();

            var actor = context.Actors.Find(id);

            if (actor == null) return NotFound();

            return Ok(actor);
        }
    }
}

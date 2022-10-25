using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Super_Hero.Models;

namespace Super_Hero.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuperHeroController : Controller
    {
        private readonly DataContext context;

        public SuperHeroController(DataContext context) { this.context = context; }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAll() { 
            return Ok(await this.context.SuperHeroes.ToListAsync());
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<SuperHero>> GetOne(int id) {
            var hero = await context.SuperHeroes.FindAsync(id);
            if (hero == null) return BadRequest("No Hero Found!");
            return Ok(hero); 
        }

        [HttpPost]
        public async Task<ActionResult<SuperHero>> Add(SuperHero hero){
            await context.SuperHeroes.AddAsync(hero);
            await context.SaveChangesAsync();
            return Ok(hero);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<SuperHero>> Update(int id, SuperHero hero){
            var _hero = await context.SuperHeroes.FindAsync(id);
            if(_hero == null) return NotFound("No Hero Founded!");
            _hero.Name = hero.Name;
            _hero.FirstName = hero.FirstName;
            _hero.LastName = hero.LastName;
            _hero.Place = hero.Place;
            await context.SaveChangesAsync();
            return Ok(_hero);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<SuperHero>> Delete(int id)
        {
            var hero = await context.SuperHeroes.FindAsync(id);
            if (hero == null) return NotFound("No Hero Founded!");
            context.SuperHeroes.Remove(hero);
            await context.SaveChangesAsync();
            return Ok(hero);
        }
    }
}

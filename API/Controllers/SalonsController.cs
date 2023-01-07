using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonsController : ControllerBase
    {
        private readonly APIContext _context;

        public SalonsController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Salons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Salons>>> GetSalons()
        {
            return await _context.Salons.ToListAsync();
        }

        // GET: api/Salons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Salons>> GetSalons(string id)
        {
            var salons = await _context.Salons.FindAsync(id);

            if (salons == null)
            {
                return NotFound();
            }

            return salons;
        }

        // PUT: api/Salons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalons(string id, Salons salons)
        {
            if (id != salons.Id)
            {
                return BadRequest();
            }

            _context.Entry(salons).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalonsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Salons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Salons>> PostSalons(Salons salons)
        {
            _context.Salons.Add(salons);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SalonsExists(salons.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSalons", new { id = salons.Id }, salons);
        }

        // DELETE: api/Salons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalons(string id)
        {
            var salons = await _context.Salons.FindAsync(id);
            if (salons == null)
            {
                return NotFound();
            }

            _context.Salons.Remove(salons);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalonsExists(string id)
        {
            return _context.Salons.Any(e => e.Id == id);
        }
    }
}

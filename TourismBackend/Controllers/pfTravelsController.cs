using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TourismBackend.DataContext;
using TourismServices.Models;

namespace TourismBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pfTravelsController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfTravelsController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfTravels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfTravel>>> GetpfTravels()
        {
            return await _context.pfTravels.ToListAsync();
        }

        // GET: api/pfTravels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfTravel>> GetpfTravel(int id)
        {
            var pfTravel = await _context.pfTravels.FindAsync(id);

            if (pfTravel == null)
            {
                return NotFound();
            }

            return pfTravel;
        }

        // PUT: api/pfTravels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfTravel(int id, pfTravel pfTravel)
        {
            if (id != pfTravel.Id)
            {
                return BadRequest();
            }

            _context.Entry(pfTravel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfTravelExists(id))
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

        // POST: api/pfTravels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfTravel>> PostpfTravel(pfTravel pfTravel)
        {
            _context.pfTravels.Add(pfTravel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfTravel", new { id = pfTravel.Id }, pfTravel);
        }

        // DELETE: api/pfTravels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfTravel(int id)
        {
            var pfTravel = await _context.pfTravels.FindAsync(id);
            if (pfTravel == null)
            {
                return NotFound();
            }

            _context.pfTravels.Remove(pfTravel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfTravelExists(int id)
        {
            return _context.pfTravels.Any(e => e.Id == id);
        }
    }
}

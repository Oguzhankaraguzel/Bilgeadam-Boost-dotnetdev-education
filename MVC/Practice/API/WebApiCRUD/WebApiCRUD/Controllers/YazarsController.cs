using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCRUD.Model;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YazarsController : ControllerBase
    {
        private readonly YazarKitapDbContext _context;

        public YazarsController(YazarKitapDbContext context)
        {
            _context = context;
        }

        // GET: api/Yazars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Yazar>>> GetYazars()
        {
          if (_context.Yazars == null)
          {
              return NotFound();
          }
            return await _context.Yazars.ToListAsync();
        }

        // GET: api/Yazars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Yazar>> GetYazar(int id)
        {
          if (_context.Yazars == null)
          {
              return NotFound();
          }
            var yazar = await _context.Yazars.FindAsync(id);

            if (yazar == null)
            {
                return NotFound();
            }

            return yazar;
        }

        // PUT: api/Yazars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYazar(int id, Yazar yazar)
        {
            if (id != yazar.Id)
            {
                return BadRequest();
            }

            _context.Entry(yazar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YazarExists(id))
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

        // POST: api/Yazars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Yazar>> PostYazar(Yazar yazar)
        {
          if (_context.Yazars == null)
          {
              return Problem("Entity set 'YazarKitapDbContext.Yazars'  is null.");
          }
            _context.Yazars.Add(yazar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYazar", new { id = yazar.Id }, yazar);
        }

        // DELETE: api/Yazars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYazar(int id)
        {
            if (_context.Yazars == null)
            {
                return NotFound();
            }
            var yazar = await _context.Yazars.FindAsync(id);
            if (yazar == null)
            {
                return NotFound();
            }

            _context.Yazars.Remove(yazar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YazarExists(int id)
        {
            return (_context.Yazars?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

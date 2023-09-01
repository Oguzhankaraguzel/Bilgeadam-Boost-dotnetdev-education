using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCRUD.Dto;
using WebApiCRUD.Model;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapsController : ControllerBase
    {
        private readonly YazarKitapDbContext _context;

        public KitapsController(YazarKitapDbContext context)
        {
            _context = context;
        }

        // GET: api/Kitaps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kitap>>> GetKitaps()
        {
            if (_context.Kitaps == null)
            {
                return NotFound();
            }
            return await _context.Kitaps.ToListAsync();
        }

        // GET: api/Kitaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kitap>> GetKitap(int id)
        {
            if (_context.Kitaps == null)
            {
                return NotFound();
            }
            var kitap = await _context.Kitaps.FindAsync(id);

            if (kitap == null)
            {
                return NotFound();
            }

            return kitap;
        }

        // PUT: api/Kitaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKitap(int id, Kitap kitap)
        {
            if (id != kitap.Id)
            {
                return BadRequest();
            }

            _context.Entry(kitap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KitapExists(id))
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

        // POST: api/Kitaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("PostKitap")]
        public async Task<ActionResult<BookCreateDTO>> PostKitap(BookCreateDTO bookCreate)
        {
            Kitap kitap = new Kitap() { KitapAd = bookCreate.KitapAdi, SayfaSayisi = bookCreate.SayfaSayisi, YazarId = bookCreate.YazarId };
            _context.Kitaps.Add(kitap);
            await _context.SaveChangesAsync();
            foreach (var item in bookCreate.kitapTurleri)
            {
                if (_context.Turs.Any(x => x.TurAd == item))
                {
                    var targetTur = _context.Turs.FirstOrDefault(x => x.TurAd == item);
                    KitapTur kitapTur = new KitapTur() { KitapId = kitap.Id, TurId = targetTur.Id };
                    await _context.KitapTurs.AddAsync(kitapTur);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    return NotFound();
                }

            }
            return RedirectToAction("GetKitap", new {id = kitap.Id}); 
        }

        // DELETE: api/Kitaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKitap(int id)
        {
            if (_context.Kitaps == null)
            {
                return NotFound();
            }
            var kitap = await _context.Kitaps.FindAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }

            _context.Kitaps.Remove(kitap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KitapExists(int id)
        {
            return (_context.Kitaps?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

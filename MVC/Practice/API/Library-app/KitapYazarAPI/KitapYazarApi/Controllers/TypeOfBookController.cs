using KitapYazarApi.DTO;
using KitapYazarApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KitapYazarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOfBookController : ControllerBase
    {
        private readonly Context _db;

        public TypeOfBookController(Context db)
        {
            _db = db;
        }

        [HttpGet]
        public List<TypeOfBook> ListTypeOfBook()
        {
            var typeOfBookList = _db.TypeOfBooks.ToList();
            return typeOfBookList;
        }
        [HttpPost]
        public async Task<IActionResult> AddTypeOfBook(CreateTypeOfBookDTO createTypeOfBookDTO)
        {
            var typeOfBook = new TypeOfBook
            {
                Type = createTypeOfBookDTO.Type
            };

            await _db.TypeOfBooks.AddAsync(typeOfBook);
            await _db.SaveChangesAsync();

            return Ok(typeOfBook);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOfBook(int id)
        {
            var selectedTypeOfBook = await _db.TypeOfBooks.FindAsync(id);
            if (selectedTypeOfBook != null)
            {
                _db.TypeOfBooks.Remove(selectedTypeOfBook);
                await _db.SaveChangesAsync();
            }
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTypeOfBook(EditTypeOfBookDTO editTypeOfBookDTO)
        {
            var existingTypeOfBook = await _db.TypeOfBooks.FindAsync(editTypeOfBookDTO.TypeOfBookId);
            if (existingTypeOfBook == null)
            {
                return NotFound();
            }

            existingTypeOfBook.Type = editTypeOfBookDTO.Type;

            _db.TypeOfBooks.Update(existingTypeOfBook);
            await _db.SaveChangesAsync();

            return Ok(existingTypeOfBook);
        }
        [HttpGet("{id}")]
        public async Task<TypeOfBook> TypeOfBookDetails(int id)
        {
            var selectedTypeOfBook = await _db.TypeOfBooks.FindAsync(id);
            return selectedTypeOfBook;
        }
    }
}

using KitapYazarApi.DTO;
using KitapYazarApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KitapYazarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthorController : ControllerBase
    {
        private readonly Context _db;

        public AuthorController(Context db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Author> ListAuthor()
        {
            var authorList = _db.Authors.ToList();
            return authorList;
        }
        [HttpPost]
        public async Task<IActionResult> AddAuthor(CreateAuthorDTO createAuthorDTO)
        {

            var author = new Author()
            {
                Name = createAuthorDTO.Name,
            };


            await _db.Authors.AddAsync(author);
            await _db.SaveChangesAsync();

            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var selectedAuthor = await _db.Authors.FindAsync(id);
            if (selectedAuthor != null)
            {
                _db.Authors.Remove(selectedAuthor);
                await _db.SaveChangesAsync();
            }
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(int id, EditAuthorDTO editAuthorDTO)
        {
            var updatedAuthor = await _db.Authors.FindAsync(editAuthorDTO.AuthorId);
            if (updatedAuthor == null)
            {
                return NotFound();
            }
            updatedAuthor.Name = editAuthorDTO.Name;

            _db.Authors.Update(updatedAuthor);
            await _db.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<Author> AuthorDetails(int id)
        {
            var selectedAuthor = await _db.Authors.FindAsync(id);
            return selectedAuthor;
        }
    }
}

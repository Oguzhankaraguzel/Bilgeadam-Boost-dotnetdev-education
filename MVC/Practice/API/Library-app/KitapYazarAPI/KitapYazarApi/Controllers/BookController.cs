using KitapYazarApi.DTO;
using KitapYazarApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KitapYazarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly Context _db;

        public BookController(Context db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Book> ListBook()
        {
            var bookList = _db.Books.ToList();
            return bookList;
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(CreateBookDTO createDTObook)
        {
            string typeOfBookName = createDTObook.Type[0];
            bool typeOfBookExists = await _db.TypeOfBooks.AnyAsync(t => t.Type == typeOfBookName);

            if (typeOfBookExists)
            {
                return BadRequest("Aynı isme sahip bir TypeOfBook zaten var.");
            }
            TypeOfBook typeOfBook = new TypeOfBook()
            {
                Type = typeOfBookName
            };

            var selectedAuthor = _db.Authors.Find(createDTObook.AuthorId);


            var book = new Book()
            {
                Name = createDTObook.Name,
                Author = selectedAuthor,
            };
            book.BookTypeOfBooks.Add(new BookTypeOfBook
            {
                TypeOfBook = typeOfBook,
            });
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();

            return Ok(book);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var selectedBook = await _db.Books.FindAsync(id);
            if (selectedBook != null)
            {
                _db.Books.Remove(selectedBook);
                await _db.SaveChangesAsync();

            }
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBook(EditBookDTO editBookDTO)
        {
            var updatedBook = await _db.Books.FindAsync(editBookDTO.BookId);
            TypeOfBook typeOfBook = new TypeOfBook()
            {
                Type = editBookDTO.Type[0],
            };

            updatedBook.Name = editBookDTO.Name;
            _db.Entry(updatedBook).Reference(x => x.Author).Load();
            updatedBook.Author.Id = editBookDTO.AuthorId;


            List<BookTypeOfBook> bookTypeOfBooks = editBookDTO.Type
    .Select(type => new BookTypeOfBook { TypeOfBook = new TypeOfBook { Type = type } })
    .ToList();


            updatedBook.BookTypeOfBooks = bookTypeOfBooks;
            _db.Books.Update(updatedBook);
            await _db.SaveChangesAsync();

            return Ok(updatedBook);

        }
        [HttpGet("{id}")]
        public async Task<Book> BookDetails(int id)
        {
            var selectedBook = await _db.Books.FindAsync(id);
            return selectedBook;
        }
    }
}

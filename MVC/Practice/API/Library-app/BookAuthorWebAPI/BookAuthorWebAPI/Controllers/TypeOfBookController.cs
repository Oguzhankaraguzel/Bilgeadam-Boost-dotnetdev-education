using BookAuthorWebAPI.Models;
using BookAuthorWebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookAuthorWebAPI.Controllers
{
    public class TypeOfBookController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            var json = await client.GetStringAsync("https://localhost:7106/api/TypeOfBook");
            var typeOfBooks = JsonConvert.DeserializeObject<List<TypeOfBook>>(json);

            return View(typeOfBooks);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TypeOfBook typeOfBook)
        {
            var json = await client.PostAsJsonAsync("https://localhost:7106/api/TypeOfBook", typeOfBook);
            return RedirectToAction("Index", "TypeOfBook");
        }
        public async Task<IActionResult> Update(int id)
        {
            var typeOfBook = await GetTypeOfBookById(id);
            if (typeOfBook == null)
            {
                return NotFound();
            }

            var viewModel = new EditTypeOfBookViewModel
            {
                Id = typeOfBook.Id,
                Type = typeOfBook.Type
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(EditAuthorViewModel viewModel)
        {
            var editAuthorDTO = new EditAuthorDTO
            {
                AuthorId = viewModel.Id,
                Name = viewModel.Name
            };

            var json = await client.PutAsJsonAsync($"https://localhost:7106/api/Author/{viewModel.Id}", editAuthorDTO);
            return RedirectToAction("Index", "Author");
        }

        private async Task<TypeOfBook> GetTypeOfBookById(int id)
        {
            var json = await client.GetStringAsync($"https://localhost:7106/api/TypeOfBook/{id}");
            var typeOfBook = JsonConvert.DeserializeObject<TypeOfBook>(json);
            return typeOfBook;
        }
        public async Task<IActionResult> Delete(int id)
        {
            var json = await client.DeleteAsync($"https://localhost:7106/api/Author/{id}");
            return RedirectToAction("Index", "Author");
        }
        public async Task<IActionResult> Details(int id)
        {
            var author = await GetTypeOfBookById(id);
            return View(author);
        }
    }
}

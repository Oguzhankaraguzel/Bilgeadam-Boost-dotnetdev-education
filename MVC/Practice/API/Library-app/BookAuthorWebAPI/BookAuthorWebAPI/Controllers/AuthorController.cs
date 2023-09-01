using BookAuthorWebAPI.Models;
using BookAuthorWebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace BookAuthorWebAPI.Controllers
{
    public class AuthorController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<IActionResult> Index()
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JwtToken"));
            var json = await client.GetStringAsync("https://localhost:7106/api/Author");
            var authors = JsonConvert.DeserializeObject<List<Author>>(json);

            return View(authors);
        }
        public async Task<IActionResult> Create()
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JwtToken"));
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AuthorViewModel authorViewModel)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JwtToken"));
            var json = await client.PostAsJsonAsync("https://localhost:7106/api/Author", authorViewModel);
            return RedirectToAction("Index", "Author");
        }
        public async Task<IActionResult> Update(int id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JwtToken"));
            var author = await GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }

            var viewModel = new EditAuthorViewModel
            {
                Id = author.Id,
                Name = author.Name
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(EditAuthorViewModel viewModel)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JwtToken"));
            var editAuthorDTO = new EditAuthorDTO
            {
                AuthorId = viewModel.Id,
                Name = viewModel.Name
            };

            var json = await client.PutAsJsonAsync($"https://localhost:7106/api/Author/{viewModel.Id}", editAuthorDTO);
            return RedirectToAction("Index", "Author");
        }

        private async Task<Author> GetAuthorById(int id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JwtToken"));
            var json = await client.GetStringAsync($"https://localhost:7106/api/Author/{id}");
            var author = JsonConvert.DeserializeObject<Author>(json);
            return author;
        }
        public async Task<IActionResult> Delete(int id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JwtToken"));
            var json = await client.DeleteAsync($"https://localhost:7106/api/Author/{id}");
            return RedirectToAction("Index", "Author");
        }
        public async Task<IActionResult> Details(int id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JwtToken"));
            var author = await GetAuthorById(id);
            return View(author);
        }
    }
}

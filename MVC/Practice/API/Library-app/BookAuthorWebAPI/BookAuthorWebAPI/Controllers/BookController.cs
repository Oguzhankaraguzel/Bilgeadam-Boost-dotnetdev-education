using BookAuthorWebAPI.Models;
using BookAuthorWebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BookAuthorWebAPI.Controllers
{
    public class BookController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            var json = await client.GetStringAsync("https://localhost:7106/api/Book");
            var books = JsonConvert.DeserializeObject<List<Book>>(json);

            return View(books);
        }
        public async Task<ActionResult> AddBook()
        {
            return View();
        }

        public async Task<ActionResult> AddBook(Book book)
        {
            var json = JsonConvert.SerializeObject(book);
            var content = new StringContent(json, Encoding.UTF8, "application/Json");

            var response = await client.PostAsync(client.GetStringAsync("https://localhost:7106/api/Book").ToString(), content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(book);
            }
        }
    }
}


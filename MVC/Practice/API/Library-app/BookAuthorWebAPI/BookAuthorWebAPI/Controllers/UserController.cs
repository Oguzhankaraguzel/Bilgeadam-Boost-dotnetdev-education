using BookAuthorWebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookAuthorWebAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UserController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInUser signInUser)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync("https://localhost:7106/api/Login", signInUser);
            if (responseMessage.IsSuccessStatusCode)
            {
                // API'den dönen token ve son kullanma süresi bilgilerini al
                var tokenResponse = await responseMessage.Content.ReadAsStringAsync();
                var tokenObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(tokenResponse);
                var token = tokenObject["token"];
                var expires = tokenObject["expires"];

                // Token'ı saklamak için uygun bir yöntem kullanabilirsiniz, örneğin session kullanabilirsiniz
                HttpContext.Session.SetString("JwtToken", token);
                return View();
            }
            else
            {
                return BadRequest();
            }

        }
    }
}

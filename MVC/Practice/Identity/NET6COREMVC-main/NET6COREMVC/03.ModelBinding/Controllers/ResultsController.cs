using Microsoft.AspNetCore.Mvc;

namespace _03.ModelBinding.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult MyViewResult()
        {
            return View("Index");
        }
        public IActionResult MyJsonResult()
        {
            //Object to json => Serialization
            //Json to object => Deserialization

            var result = Json(new { isim = "Fatih Kaan", soyIsim = "Açıkgöz" });
            result.ContentType = "application/json";
            result.StatusCode = 200;
            //return Ok(result);
            return Ok(result.Value);
        }
        public IActionResult MyFileResult()
        {
            var downloadedFileName = $"soyutlama{DateTime.UtcNow.ToString()}.jpeg";
            return File("~/Files/Abstraction.jpeg", "image/jpeg",downloadedFileName);
        }
        [Route("/")]
        public IActionResult Yonlen()
        {
            Response.Headers["test"] = "test";
            return Redirect("https://www.google.com");
        }

    }
}

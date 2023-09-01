using Microsoft.AspNetCore.Mvc;

namespace _05.JQUERY_AJAX_VALIDATIONS.Controllers
{
    public class ErrorController : Controller
    {
        
        public IActionResult Bulunamadi()
        {

            return NotFound("SUNUCUMDA BÖYLE BİR ACTION YOK!");
        }
    }
}

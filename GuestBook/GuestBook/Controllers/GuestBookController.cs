using GuestBook.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace GuestBook.Controllers
{
    public class GuestBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendAction([FromBody]GuestBookSendActionDto guestBookSendActionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Biz de yapardık zamanında");
            }

            return new JsonResult("ok");
        }
    }
}
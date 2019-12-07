using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestBook.Data.Context;
using GuestBook.Data.Dto;
using GuestBook.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuestBook.Controllers
{
    public class GuestBookController : Controller
    {
        private readonly DataContext _dataContext;

        public GuestBookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            List<GuestNote> guestNotes = _dataContext.GuestNotes.ToList();
            return View(guestNotes);
        }
        public IActionResult Manage()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                return RedirectToAction("AdminDashboard","GuestBook");
            }

            return View();
        }

        public IActionResult LoginAction([FromBody]GuestBookLoginDto guestBookLoginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Bizde yapardık zamanında");
            }

            User user = _dataContext.Users.SingleOrDefault(a =>
                a.Username == guestBookLoginDto.Username && a.Password == guestBookLoginDto.Password);

            if (user != null)
            {
                HttpContext.Session.SetInt32("userId", user.Id);
                return new JsonResult("OK");
            }
            else
            {
                return Unauthorized();
            }
        }

        public IActionResult LogoutAction()
        {
            HttpContext.Session.Remove("userId");

            return RedirectToAction("Manage", "GuestBook");
        }

        public IActionResult AdminDashboard()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Manage", "GuestBook");
            }
        }

        public IActionResult SendAction([FromBody]GuestBookSendActionDto guestBookSendActionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Bizde yapardık zamanında");
            }
            GuestNote guestNote = new GuestNote
            {
                Name = guestBookSendActionDto.Name,
                Surname = guestBookSendActionDto.Surname,
                Email = guestBookSendActionDto.Email,
                Message = guestBookSendActionDto.Message,
                CreateDate = DateTime.Now
            };

            _dataContext.GuestNotes.Add(guestNote);
            _dataContext.SaveChanges();

            return new JsonResult("ok");
        }
    }
}
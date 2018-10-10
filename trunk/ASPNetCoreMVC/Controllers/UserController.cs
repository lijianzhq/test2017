using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ASPNetCoreMVC.Models;

namespace ASPNetCoreMVC.Controllers
{
    public class UserController : Controller
    {
        private DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {       
            return View(_context.Users.ToList());
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User registeruser)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(registeruser);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registeruser);
        }
    }
}

using IndiaMirror.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMirror.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;
        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Users student)
        {
            if (ModelState.IsValid)
            {
                Users newStudent = _userRepo.Add(student);
                return RedirectToAction("details", new { id = newStudent.Id });
            }
            return View();
        }
    }
}

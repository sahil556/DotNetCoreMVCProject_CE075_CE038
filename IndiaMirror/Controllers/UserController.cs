using IndiaMirror.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace IndiaMirror.Controllers
{
    public class UserController : Controller
    {
        const string SessionId= "_UserId";
        private readonly IUserRepository _userRepo;
        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public IActionResult Index()
        {
           
            int id = HttpContext.Session.GetInt32(SessionId) ?? 0;
            if (id == 0)
            {
                return RedirectToAction("Login");
            }

            Users user = _userRepo.GetUsers(id);
            ViewBag.user = user;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Users user)
        {
            if (ModelState.IsValid)
            {

                Users newStudent = _userRepo.Add(user);
                return RedirectToAction("index", new { id = newStudent.Id });
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(String email, String password)
        { 
            Users user = _userRepo.GetUserByEmail(email);
            if(user != null && user.Password == password)
            {
                HttpContext.Session.SetInt32(SessionId, user.Id);
                return RedirectToAction("index");
            }
            ViewBag.error = "Enter a Valid Credential !";
            return View();
        }
    }
}

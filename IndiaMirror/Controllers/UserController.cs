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
        private readonly IAdvertisementRepository _advertisementRepository;
        public UserController(IUserRepository userRepo,IAdvertisementRepository advertisementRepo)
        {
            _userRepo = userRepo;
            _advertisementRepository = advertisementRepo; 
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

        [HttpGet]
        public IActionResult AddAdvertisement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdvertisement(Advertisement advertisement)
        {
            if(advertisement.start_time.Date != advertisement.end_time.Date)
            {
                ViewBag.error = "Time Period must be within same day.";
                return View();
            }
            _advertisementRepository.Add(advertisement);
            return RedirectToAction("index");
        }
    }
}

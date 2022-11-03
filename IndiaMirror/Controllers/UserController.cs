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
            var Model = _advertisementRepository.GetAdvertisements_user(id);
            return View(Model);
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
            
            if (HttpContext.Session.GetInt32(SessionId) == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddAdvertisement(Advertisement advertisement)
        {
            int id = HttpContext.Session.GetInt32(SessionId) ?? 0;
            if (id == 0)
            {
                return RedirectToAction("Login");
            }
            advertisement.user_id = id;
            advertisement.payment = "False";
            advertisement.reason = "";
            advertisement.status = "pending";
            if (advertisement.start_time.Date != advertisement.end_time.Date)
            {
                ViewBag.error = "Time Period must be within same day.";
                return View();
            }
            _advertisementRepository.Add(advertisement);
            String url = "payment/" + id.ToString();
            return RedirectToRoute(url);
        }

        [HttpGet]
        public ViewResult EditAdvertisement(int id)
        {
            Advertisement ad = _advertisementRepository.GetAdvertisement(id);
            return View(ad);
        }

        [HttpPost]
        public IActionResult EditAdvertisement(Advertisement advertisement)
        {
          
                Advertisement ad = _advertisementRepository.GetAdvertisement(advertisement.Id);
                ad.image_url = advertisement.image_url;
                ad.business_url = advertisement.business_url;
                ad.category = advertisement.category;
                ad.start_time = advertisement.start_time;
                ad.end_time = advertisement.end_time;
                ad.title = advertisement.title;
                ad.description = advertisement.description;
                _advertisementRepository.Update(ad);
            
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            if (HttpContext.Session.GetInt32(SessionId) == null)
            {
                return RedirectToAction("Login");
            }
            var Model = _advertisementRepository.GetAdvertisement(Id);
            if(Model == null)
            {
                return RedirectToAction("index");
            }
            return View(Model);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (HttpContext.Session.GetInt32(SessionId) == null)
            {
                return RedirectToAction("Login");
            }
            var Model = _advertisementRepository.GetAdvertisement(Id);
            if (Model == null)
            {
                return RedirectToAction("index");
            }
            return View(Model);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirm(int Id)
        {
            if (HttpContext.Session.GetInt32(SessionId) == null)
            {
                return RedirectToAction("Login");
            }
            _advertisementRepository.Delete(Id);
            return RedirectToAction("index");
        }
        [HttpGet] 
        public IActionResult payment(int Id)
        {
           
            Advertisement ad = _advertisementRepository.GetAdvertisement(Id);
            if(ad.payment == "Done")
            {
                return RedirectToAction("index");
            }
            ViewBag.Id = Id;

            return View();
        }

        [HttpPost,ActionName("payment")]
        public IActionResult paymentConfirm(int Id)
        { 
            Advertisement ad = _advertisementRepository.GetAdvertisement(Id);
            ad.payment = "Done";
            _advertisementRepository.Update(ad);

            return RedirectToAction("index");
        }
       }
}

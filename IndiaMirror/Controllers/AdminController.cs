using IndiaMirror.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMirror.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdvertisementRepository _advertisementRepository;

        public AdminController(IAdvertisementRepository advertisementRepo)
        {
            _advertisementRepository = advertisementRepo;
        }
        public IActionResult Index()
        {
            var Model = _advertisementRepository.GetAdvertisements_admin("pending");
            return View(Model);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Advertisement ad = _advertisementRepository.GetAdvertisement(id);
            return View(ad);
        }

        [HttpPost]
        public IActionResult Edit(Advertisement advertisement)
        {

            Advertisement ad = _advertisementRepository.GetAdvertisement(advertisement.Id);
            ad.status = advertisement.status;
            ad.reason = advertisement.reason;
            
            _advertisementRepository.Update(ad);

            return RedirectToAction("index");
        }

        public ViewResult Reject(int id)
        {
            Advertisement ad = _advertisementRepository.GetAdvertisement(id);
            return View(ad);
        }

        [HttpPost]
        public IActionResult Reject(Advertisement advertisement)
        {

            Advertisement ad = _advertisementRepository.GetAdvertisement(advertisement.Id);
            ad.status = advertisement.status;
            ad.reason = advertisement.reason;
            ad.payment = "Refund Completed";
            _advertisementRepository.Update(ad);

            return RedirectToAction("index");
        }
    }
}

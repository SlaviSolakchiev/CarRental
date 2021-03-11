using CarRental.Data;
using CarRental.Data.Models;
using CarRental.Models;
using CarRental.ViewModels.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            db = dbContext;
        }


        public IActionResult Index(IndexViewModel model)
        {
            var viewModel = new IndexViewModel();
            var cars = db.Cars
                .Select(c => new SelectListItem
                {
                    Value = $"{c.Id}",
                    Text = $"{c.Brand}, {c.Model} {c.Year} - {c.PriceForDay}$/day"
                })
                .ToList();

            var locations = db.Locations
                .Select(l => new SelectListItem
                {
                    Value = $"{l.Id}",
                    Text = $"{l.Country}, {l.Town} {l.District} {l.Street} {l.Number}"
                })
                .ToList();

            viewModel.LocationItems = locations;
            viewModel.CarItems = cars;

            

            var importModel = new ReservationInputModel()
            {
                CarId = model.Car,
                UserName = model.UserName,
                UserId = db.Users.Where(x => x.UserName == model.UserName).Select(x => x.Id).ToString(),
                TelephoneNumber = model.TelephoneNumber,
                PickUpDate = model.PickUpDate,
                ReturnDate = model.ReturnDate,
                PickUpLocation = model.PickUpLocation,
                ReturnLocation = model.ReturnLocation

            };





            if (ModelState.IsValid)
            {
                var newUser = new ApplicationUser()
                {
                    UserName = importModel.UserName,
                    TelephoneNumber = importModel.TelephoneNumber
                };
                db.Users.Add(newUser);
                db.SaveChanges();




                var newReservation = new ReservationInfo()
                {
                    PickUpDate = importModel.PickUpDate,
                    ReturnDate = importModel.ReturnDate,
                    UserId = newUser.Id,
                    CarId = int.Parse(importModel.CarId),
                    PickUpLocationId = int.Parse(importModel.PickUpLocation),
                    ReturnLocationId = int.Parse(importModel.ReturnLocation)
                };

                db.ReservationInfos.Add(newReservation);
                db.SaveChanges();

                var currUser = db.Users.FirstOrDefault(x => x.UserName == importModel.UserName);

                currUser.ReservationInfoId = newReservation.Id;







                db.SaveChanges();
            }






            return View(viewModel);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }


        public IActionResult ContactUs()
        {
            return View();
        }









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

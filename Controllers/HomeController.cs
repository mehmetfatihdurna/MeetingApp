using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{
    public class HomeController: Controller{
        public IActionResult Index(){
            int hour = DateTime.Now.Hour;
            ViewBag.Selamlama = hour > 12 ? "İyi Günler" : "Günaydın";

            ViewBag.UserName = "Fatih";

            ViewData["saat"] = DateTime.Now.Hour;
            ViewData["dakika"] = DateTime.Now.Minute;

            MeetingInfo meeting = new(){
                Id=1,
                Date=new DateTime(2024,12,14,20,0,0),
                Location="Eskisehir",
                NumberOfPeople=1};

            return View(meeting);
        }
    }
}
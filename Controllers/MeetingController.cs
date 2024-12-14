using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController: Controller
    {
        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(string Name,string PhoneNumber, string Email, bool WillAttend){
            Console.WriteLine(Name + " " + PhoneNumber + " " + Email + " " + WillAttend);
            return View();
        }

        public IActionResult List(){
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{
    public class DenemeController : Controller{
        public string Index(){
            return "deneme controller";
        }

        public string Hi(){
            return "Hi Hi!";
        }
    }
}
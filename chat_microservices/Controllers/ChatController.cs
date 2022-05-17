using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace chat_microservices.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> Rooms = 
            new Dictionary<int, string>()
        {
                {1, "usuarios" }
        };
           
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room ( int room )
        {
            return View("Room", room);
        }
    }
}

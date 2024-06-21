using Mentor_App_Task_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mentor_App_Task_2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
using AuctionProject;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using AuctionProject.Models;

namespace AuctionProject.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
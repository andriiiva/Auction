using AuctionProject;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using AuctionProject.Models;
using System;

namespace AuctionProject.Controllers
{
    [Route("api/auction")]
    public class AuctionController : Controller
    {
        private readonly ApplicationContext _context;

        public AuctionController(ApplicationContext context) {
            this._context = context;
        }

        [HttpGet]
        public List<Lot> getLots()
        {
            return _context.Lots.ToList();
        }

        [HttpPost]
        public ActionResult addLot([FromBody] Lot lot)
        {
            _context.Lots.Add(lot);
            _context.SaveChanges();
            return Ok(lot);
        }
    }
}
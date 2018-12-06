using AuctionProject;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using AuctionProject.Models;
using System;
using Microsoft.EntityFrameworkCore;

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
            return _context.Lots.Include(l => l.User).ToList();
        }

        [HttpPost]
        public ActionResult addLot([FromBody] Lot lot)
        {
            _context.Lots.Add(lot);
            _context.SaveChanges();
            return Ok(lot);
        }


        [HttpGet("lot/{id}")]
        public IActionResult Lot(int id) {
            var lot = _context.Lots.Find(id);
            return Ok(lot);
        }
    }
}
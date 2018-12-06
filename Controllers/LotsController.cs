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
    [Route("/lots")]
    public class LotsController : Controller
    {
        private readonly ApplicationContext _context;

        public LotsController(ApplicationContext context) {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.lots = _context.Lots.Include(l => l.User).ToList();
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Lot(int id) {
            ViewBag.lot = _context.Lots.Include(l => l.User).SingleOrDefault(l => l.Id == id);
            ViewBag.bids = _context.Bids.Where(li => li.LotId == id);
            return View();
        }

        [HttpPost]
        public IActionResult AddLot([FromBody] Lot lot)
        {
            _context.Lots.Add(lot);
            _context.SaveChanges();
            return Ok(lot);
        }

        [HttpPost("{id}")]
        public IActionResult AddBid(int id, [FromBody] Bid bid)
        {
            var lot = _context.Lots.Find(id);
            lot.Bids.Add(bid);
            _context.Bids.Add(bid);
            _context.SaveChanges();
            return Ok(bid);
        }
    }
}
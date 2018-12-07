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
            if (ModelState.IsValid) {
                _context.Lots.Add(lot);
                _context.SaveChanges();
                return Ok(_context.Lots.Include(l => l.User).SingleOrDefault(l => l.Id == lot.Id));
            }

            return UnprocessableEntity(ModelState);
        }

        [HttpGet("lot/{id}")]
        public IActionResult Lot(int id) {
            var lot = _context.Lots.Find(id);
            return Ok(_context.Lots.Include(l => l.Bids).ThenInclude(b => b.User).SingleOrDefault(l => l.Id == lot.Id));
        }

        [HttpPost("lot")]
        public ActionResult addBid([FromBody] Bid bid)
        {
            _context.Bids.Add(bid);
            _context.SaveChanges();
            return Ok(_context.Bids.Include(l => l.User).SingleOrDefault(b => b.Id == bid.Id));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionProject.Models
{
    public class Lot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartPrice { get; set; }
        public string Description { get; set; }
        public List<Bid> Bids { get; set; } = new List<Bid>();
        public List<AutoBid> AutoBids { get; set; } = new List<AutoBid>();
        public int UserId { get; set; }
        public User User { get; set; }
        public Lot()
        {
        }

        public Lot(string name, int startPrice, string description, int userId)
        {
            this.Name = name;
            this.StartPrice = startPrice;
            this.Description = description;
            this.UserId = userId;
        }

        public void MakeBid(Bid bid)
        {
            Bids.Add(bid);
        }

        public void AutoBid(AutoBid autobid)
        {
            AutoBids.Add(autobid);
        }

    }
}
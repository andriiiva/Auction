using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionProject.Models
{
    public class Lot
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StartPrice { get; set; }
        public List<Bid> Bids { get; set; } = new List<Bid>();
        public List<AutoBid> AutoBids { get; set; } = new List<AutoBid>();
       
        public Lot()
        {
        }

        public Lot(string name, int startprice)
        {
            this.Name = name;
            this.StartPrice = startprice;
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
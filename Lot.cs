using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionProject
{
    public class Lot
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int StartPrice { get; private set; }
        public Auction Auction { get; private set; }
        public User User { get; private set; }
        public List<Bid> Bids { get; private set; } = new List<Bid>();
        public List<AutoBid> AutoBids { get; private set; } = new List<AutoBid>();

        public Lot(string name, Auction auction, User user, int startprice)
        {
            this.Name = name;
            this.Auction = auction;
            this.User = user;
            this.StartPrice = startprice;
        }
        public Lot()
        {

        }

        public void MakeBid(Bid bid)
        {
            Bids.Add(bid);
            CheckAutoBid();
        }

        public void AutoBid(AutoBid autobid)
        {
            AutoBids.Add(autobid);
        }

        public void CheckAutoBid()
        {
            Bid lastbid = Bids.Last();

            foreach(AutoBid ab in AutoBids)
            {
                if (lastbid.NextMinBid() <= ab.MaxPrice && ab.User.ID != lastbid.User.ID)
                {
                    MakeBid( new Bid(ab.User, lastbid.NextMinBid()) );
                }
            }           
        }
    }
}
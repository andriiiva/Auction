using System;
using System.Collections.Generic;

namespace AuctionProject.Models
{
    public class User
    {
        public User(int iD, string name) 
        {
            this.ID = iD;
                this.Name = name;
               
        }
        public int ID { get; private set; }
        public string Name { get; private set; }
        // public List<Lot> lots { get; set; }
        public List<AutoBid> AutoBids { get; set; }
        public List<Lot> Lots { get; set; }
        public List<Bid> Bids { get; set; }

        public User()
        {
        }

        public User(string name)
        {
            Name = name;
        }
    }
}

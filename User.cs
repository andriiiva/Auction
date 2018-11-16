using System;
using System.Collections.Generic;

namespace AuctionProject
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
        public List<Bid> Bids { get; set; }
        public List<Lot> Lots { get; set; }
        public List<AutoBid> AutoBids { get; set; }
        public List<AuctionUsers> AuctionUsers { get; set; }

        public User()
        {
        }

        public User(string name)
        {
            Name = name;
        }
    }
}

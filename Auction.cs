using System;
using System.Collections.Generic;
using System.Linq;

namespace AuctionProject
{
    public class Auction
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public AuctionStatus Status { get; private set; }
        public List<Lot> Lots { get; set; } = new List<Lot>();
        public List<AuctionUsers> AuctionUsers { get; private set; }

        public Auction() 
        {
        }

        public Auction(string name) 
        {
            Name = name;
        }

        public void StartAuction()
        {
            OpenAuction();
            List<User> users = new List<User>();
            foreach(var u in AuctionUsers)
            {
                users.Add(u.User);
            }
            for(int i = 1; i <= GetCountLots(); i++)
            {
                if(i == 2)
                {
                    AutoBid(2, new AutoBid(users[0], 2000));
                    MakeBid(2, new Bid(users[2], 170));
                    MakeBid(2, new Bid(users[1], 200));
                    MakeBid(2, new Bid(users[2], 250));
                    MakeBid(2, new Bid(users[1], 400));
                    MakeBid(2, new Bid(users[2], 1800));
                }
            }
            CloseAuction();
        }
        public void OpenAuction()
        {
            Status = AuctionStatus.STARTED; 
        }        
        public void CloseAuction()
        {
            Status = AuctionStatus.CLOSED;
        }

        public int GetCountLots()
        {
            return Lots.Count;
        }

        public void MakeBid(int lotID, Bid bid)
        {
            var lot = SearchLot(lotID);
            lot.MakeBid(bid);
        }

        public void AutoBid(int lotID, AutoBid autobid)
        {
            if ( !isAuctionStatus(AuctionStatus.CLOSED) )
            {
                var lot = SearchLot(lotID);
                lot.AutoBid(autobid);
            }
        }

        public bool isAuctionStatus(AuctionStatus status)
        {
            return Status == status;
        }

        private Lot SearchLot(int lotID)
        {
            return Lots.Where(value => value.ID == ID).FirstOrDefault();
        }
    }
}
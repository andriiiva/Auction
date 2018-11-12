using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AuctionProject 
{
    class Auction
    {
        public int AuctionID { get; private set; }
        public static int Count { get; private set; }
        public AuctionStatus Status { get; private set; }
        List<User> Bidders = new List<User>();
        List<Lot> lots = new List<Lot>();
        
        public Auction() 
        {
            Count = Count + 1;
            AuctionID = Count;
            Status = AuctionStatus.NOTSTARTED;
        } 
        
        public void StartAuction()
        {
            if(Status == AuctionStatus.NOTSTARTED) 
            { 
                Status = AuctionStatus.STARTED; 
            }
        }
        
        public void CloseAuction()
        {
            if(Status == AuctionStatus.STARTED) 
            { 
                Status = AuctionStatus.CLOSED;
            }
        }

        public void StartSellLot(int lotID)
        {
            if(Status == AuctionStatus.STARTED) 
            { 
                var lot = SearchLot(lotID);
                lot.AddToSell();
            }
        }
        public void CloseSellLot(int lotID)
        {
            var lot = SearchLot(lotID);
            lot.RemoveFromSell();
        }
        
        public void AddLot(Lot lot)
        {
            if ( isAuctionStatus(AuctionStatus.NOTSTARTED ) )
            {
                lots.Add(lot);
            }
        }

        public void AutoBid(int lotID, AutoBid autobid)
        {
            if ( !isAuctionStatus(AuctionStatus.CLOSED) )
            {
                var lot = SearchLot(lotID);
                lot.Autobid.Add(autobid);
            }
        }

        public void CheckAutoBid(Lot lot)
        {
            var ab = lot.GetAutoBid();
            if((object)ab != (object)null)
            {
                MakeBid(lot.LotID, ab.User, lot.bid.GetMinBid());
            }
        }

        public void AddBidder(User user)
        {
            Bidders.Add(user);
        }
        
        public void MakeBid(int lotID, User user, int newBid)
        {
            var lot = SearchLot(lotID);
            if ( lot.bid.isValidPrice(newBid) && lot.isOnSale() && isBidder(user) && user.UserID != lot.bid.UserID)
            {
                lot.ChangeBid(user.UserID, newBid);
                CheckAutoBid(lot);
            }
        }
        
        public int GetCountLots()
        {
            return lots.Count;
        }

        public string ShowLotList()
        {
            string showlots = "";
            foreach(Lot l in lots)
            {
                showlots = showlots + "ID: " + l.LotID + "\n";
                showlots = showlots + "Price: " + l.bid.Price + "\n";
                showlots = showlots + "Min. bid: " + l.bid.Step + "\n";
                showlots = showlots + "\n";
            }
            return showlots;
        }
        
        public string ShowLot(int lotID)
        {
            var lot = SearchLot(lotID);
            string showlots = "";
            showlots = showlots + "ID: " + lot.LotID + "\n";
            showlots = showlots + "Price: " + lot.bid.Price + "\n";
            showlots = showlots + "Min. bid: " + lot.bid.Step + "\n";
            showlots = showlots + "\n";
            return showlots;
        }
        
        private Lot SearchLot(int lotID)
        {
            return lots.Where(value => value.LotID == lotID).FirstOrDefault();
        }

        private bool isBidder(User user)
        {
            return Bidders.Contains(user);
        }
        
        private bool isAuctionStatus (AuctionStatus status)
        {
            return Status == status;
        }
    }
}
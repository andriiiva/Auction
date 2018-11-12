using System;
using System.Collections.Generic;
namespace AuctionProject 
{
    class Lot
    {
        public int LotID { get; private set; }
        public static int Count { get; private set; }
        public bool onSale { get; private set; } = false;
        public List<AutoBid> Autobid = new List<AutoBid>();
        public Bid bid { get; private set; }
        
        public Lot(int price) 
        {
            Count = Count + 1;
            LotID = Count;
            bid = new Bid(price);
        }
        
        public void ChangeBid(int userID, int newBid)
        {
            bid.SetPrice(newBid);
            bid.SetUser(userID);
        }

        public bool isOnSale()
        {
            return onSale;
        }

        public void AddToSell()
        {
            onSale = true;
        }

        public void RemoveFromSell()
        {
            onSale = false;
        }

        public AutoBid GetAutoBid()
        {  
            foreach(AutoBid ab in Autobid)
            {
                if (bid.isValidPrice(ab.Price))
                {
                    return ab;
                }
            }
            return null;
        }

    }
}

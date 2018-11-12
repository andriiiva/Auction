using System;
namespace AuctionProject 
{
    class Bid
    {
        public int Price { get; private set; }
        public int UserID { get; private set; }
        public int Step { get; private set; }
        
        public Bid(int price)
        {
            Price = price;
            SetStep(Price);
        }
        
        public void SetStep(int price)
        {
            Step = CalculationStep(price);
        }
        
        public int GetMinBid()
        {
            return Price + Step;
        }

        public int CalculationStep(int price)
        {
            double step = Math.Round(price * 0.05f);
            if (step < 1) {
                step = 1;
            } else if ( step >= 2 && step <= 3) {
                step = 2;
            } else if ( step >=4 && step <=7 ) {
                step = 5;
            } else if ( step >= 8 && step <= 15 ) {
                step = 10;
            } else if ( step >= 16 && step < 60) {
                step = 20;
            } else if ( step > 60) {
                step = 100;
            }
            return (int)step;
        }
        
        public bool isValidPrice(int price)
        {
            return price >= Price + Step;
        }
        
        public void SetPrice(int price)
        {
            Price = price;
        }
        
        public void SetUser(int userID)
        {
            UserID = userID;
        }
        
    }
}

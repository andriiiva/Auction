using System;
namespace AuctionProject.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int LotId { get; set; }
        public Lot Lot { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public Bid()
        {
        }
        public Bid(int price, int userId)
        {
            this.Price = price;
            this.UserId = userId;
        }

        public int NextMinBid()
        {
            return Price + CalculationStep(Price);
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

    }
}
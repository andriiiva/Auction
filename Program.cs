using System;
using System.Collections.Generic;
namespace AuctionProject
{
    class Program 
    {
        static void Main() 
        {
            using (AppContext applicationContext = new AppContext())
            {
                
                applicationContext.Database.EnsureCreated();
            }
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            Lot lot1 = new Lot(85);
            Lot lot2 = new Lot(150);
            
            Auction auction1 = new Auction();

            auction1.AddLot( lot1 );
            auction1.AddLot( lot2 );
            auction1.AddBidder( user1 );
            auction1.AddBidder( user3 );
            auction1.AddBidder( user4 );
            
            auction1.StartAuction();
            for(int i = 1; i <= auction1.GetCountLots(); i++)
            {
                auction1.StartSellLot(i);
                auction1.AutoBid(2, new AutoBid(user1, 2000));
                auction1.MakeBid(2, user4, 172);
                auction1.MakeBid(2, user3, 200);
                auction1.MakeBid(2, user4, 252);
                auction1.MakeBid(2, user3, 400);
                auction1.MakeBid(2, user4, 666);
                auction1.CloseSellLot(i);
            }
            auction1.CloseAuction();

            Console.WriteLine(auction1.ShowLotList());

        }
    }
}

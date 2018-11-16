using System;
using System.Linq;
namespace AuctionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext AuctionDB = new ApplicationContext())
            {
                AuctionDB.Database.EnsureCreated();
                User u1 = new User("u1");
                AuctionDB.Users.Add(u1);
                User u2 = new User("u2");
                AuctionDB.Users.Add(u2);
                User u3 = new User("u3");
                AuctionDB.Users.Add(u3);
                User u4 = new User("u4");
                AuctionDB.Users.Add(u4);

                Auction a1 = new Auction("a1");
                AuctionDB.Auctions.Add(a1);

                Lot lot1 = new Lot("lot1", a1, u2, 150);
                Lot lot2 = new Lot("lot2", a1, u2, 150);
                AuctionDB.Lots.Add(lot1);
                AuctionDB.Lots.Add(lot2);

                AuctionUsers AU1 = new AuctionUsers(a1,u1);
                AuctionUsers AU2 = new AuctionUsers(a1,u3);
                AuctionUsers AU3 = new AuctionUsers(a1,u4);
                AuctionDB.AuctionUsers.Add(AU1);
                AuctionDB.AuctionUsers.Add(AU2);
                AuctionDB.AuctionUsers.Add(AU3);
                
                a1.StartAuction();

                AuctionDB.SaveChanges();
                //AutoBid abit = new AutoBid(u3, 200);
                //lot1.AutoBids.Add(abit);


            }
        }
    }
}

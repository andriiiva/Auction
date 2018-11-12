namespace AuctionProject
{
   class AutoBid
   {
        public User User { get; private set; }
        public int Price { get; private set; }

        public AutoBid(User user, int price)
        {
            User = user;
            Price = price;
        }
   }
}

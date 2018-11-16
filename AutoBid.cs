namespace AuctionProject
{
    public class AutoBid
    {
        public int ID { get; private set; }
        public int MaxPrice { get; private set; }
        public Lot Lot { get; private set; }
        public User User { get; private set; }

        public AutoBid()
        {
        }

        public AutoBid(User user, int maxprice)
        {
            this.User = user;
            this.MaxPrice = maxprice;
        }
    }
}
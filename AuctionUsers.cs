namespace AuctionProject
{
    public class AuctionUsers
    {
        public Auction Auction { get; private set; }
        public int AuctionID { get; private set; }
        public User User { get; private set; }
        public int UserID { get; private set; }
        public AuctionUsers()
        {
        }
        public AuctionUsers(Auction auction, User user)
        {
            this.User = user;
            this.Auction = auction;
        }
    }
}
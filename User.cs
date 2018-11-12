using System;
namespace AuctionProject
{
    class User
    {
        public int UserID { get; private set; }
        public static int Count { get; private set; }
        public User() 
        {
            Count = Count + 1;
            UserID = Count;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace AuctionProject
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<AuctionUsers> AuctionUsers { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<AutoBid> AutoBids { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=1111;database=APDB;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionUsers>()
                .HasKey(bc => new { bc.AuctionID, bc.UserID });

            modelBuilder.Entity<AuctionUsers>()
                .HasOne(bc => bc.Auction)
                .WithMany(b => b.AuctionUsers)
                .HasForeignKey(bc => bc.AuctionID);

            modelBuilder.Entity<AuctionUsers>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.AuctionUsers)
                .HasForeignKey(bc => bc.UserID);

            modelBuilder.Entity<Lot>()
                .HasMany(bc => bc.Bids)
                .WithOne(e => e.Lot);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Bids)
                .WithOne(e => e.User);

            modelBuilder.Entity<Lot>()
                .HasMany(bc => bc.AutoBids)
                .WithOne(e => e.Lot);

            modelBuilder.Entity<User>()
                .HasMany(c => c.AutoBids)
                .WithOne(e => e.User);
        }

    }
}
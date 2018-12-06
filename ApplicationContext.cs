using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using AuctionProject.Models;

namespace AuctionProject
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<AutoBid> AutoBids { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=1111;database=APDB;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lot>()
                .HasOne(l => l.User)
                .WithMany(u => u.Lots)
                .HasForeignKey(l => l.UserId);

            modelBuilder.Entity<Bid>()
                .HasOne(e => e.User)
                .WithMany(e => e.Bids);

            //test

            modelBuilder.Entity<Lot>()
                .HasMany(bc => bc.Bids)
                .WithOne(e => e.Lot);

            // modelBuilder.Entity<Lot>()
            //     .HasMany(bc => bc.AutoBids)
            //     .WithOne(e => e.Lot);

            // modelBuilder.Entity<User>()
            //     .HasMany(c => c.AutoBids)
            //     .WithOne(e => e.User);
        }

    }
}
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace AuctionProject
{
    class AppContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=1234;database=AuctionDB;");
        }
    }
}
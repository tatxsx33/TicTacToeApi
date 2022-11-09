using System;
using Microsoft.EntityFrameworkCore;

namespace APITicTacToe.Models
{
    public class DataContext :DbContext
 {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } //malo

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerMove>() //category
                .HasMany(c => c.Games)  //products
                .WithOne(a => a.PlayerMove)  //category
                .HasForeignKey(a => a.PlayerMoveId);

            modelBuilder.Memory();
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerMove> PlayerMoves { get; set; }

       public DbSet<GameList> GameLists { get; set; }//LIST  


    }
    
}


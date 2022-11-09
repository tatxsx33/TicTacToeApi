using APITicTacToe.Models;
using Microsoft.EntityFrameworkCore;

namespace APITicTacToe.Models
{
    public static class ModelBuilderExtensions //the InMemory DataBae
    {
        public static void Memory(this ModelBuilder modelBuilder) 
        {


            modelBuilder.Entity<Game>().HasData( //

            new Game { Id = 1, PlayerMoveId = 1, Player1 = "Kraken" }, //new Player
            new Game { Id = 2, PlayerMoveId = 2, Player2 = "Bender" },
            new Game { Id = 3, PlayerMoveId = 1, Player1 = "Terminator" },
            new Game { Id = 4, PlayerMoveId = 2, Player2 = " Chew Chew" },
            new Game { Id = 5, PlayerMoveId = 2, Player1 = " Wildcat" },
            new Game { Id = 6, PlayerMoveId = 2, Player2 = " Dexter" },
            new Game { Id = 7, PlayerMoveId = 2, Player1 = " Cobra" },
            new Game { Id = 8, PlayerMoveId = 2, Player2 = " Wildcat" },
            new Game { Id = 9, PlayerMoveId = 2, Player1 = " Fury" },
            new Game { Id = 10, PlayerMoveId = 2, Player2 = " Daemon" },
            new Game { Id = 11, PlayerMoveId = 2, Player1 = " Wildcat" },
            new Game { Id = 12, PlayerMoveId = 2, Player2 = " Snake" },
            new Game { Id = 13, PlayerMoveId = 2, Player1 = " Alpha" },
            new Game { Id = 14, PlayerMoveId = 2, Player2 = " Dracula" },
            new Game { Id = 15, PlayerMoveId = 2, Player1 = " Wildcat" },
            new Game { Id = 16, PlayerMoveId = 2, Player2 = " Titanium" },
            new Game { Id = 17, PlayerMoveId = 2, Player1 = " BlacKitten" },
            new Game { Id = 18, PlayerMoveId = 2, Player2 = " Ironsides" },
            new Game { Id = 19, PlayerMoveId = 2, Player1 = " Razor" },
            new Game { Id = 20, PlayerMoveId = 2, Player1 = " Razor" },
            new Game { Id = 21, PlayerMoveId = 2, Player1 = " Razor" },
            new Game { Id = 22, PlayerMoveId = 2, Player1 = " Razor" },
            new Game { Id = 23, PlayerMoveId = 2, Player1 = " Razor" },
            new Game { Id = 24, PlayerMoveId = 2, Player1 = " Razor" },
            new Game { Id = 25, PlayerMoveId = 2, Player1 = " Razor" },
            new Game { Id = 26, PlayerMoveId = 2, Player1 = " Razor" },
            new Game { Id = 27, PlayerMoveId = 1, Player2 = "Lightning" });



            modelBuilder.Entity<PlayerMove>().HasData(
           new PlayerMove { Id = 1, Player1 = "move ", MoveWin = true },
           new PlayerMove { Id = 2, Player2 = "move", MoveWin = false },
           new PlayerMove { Id = 3, Player1 = "Move", MoveWin = true },
           new PlayerMove { Id = 4, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 5, Player1 = "move", MoveWin = true },
           new PlayerMove { Id = 6, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 7, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 8, Player1 = "move", MoveWin = true },
           new PlayerMove { Id = 9, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 10, Player1 = "move", MoveWin = true },
           new PlayerMove { Id = 11, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 12, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 13, Player1 = "move", MoveWin = true },
           new PlayerMove { Id = 14, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 15, Player1 = "move", MoveWin = true },
           new PlayerMove { Id = 16, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 17, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 18, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 19, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 20, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 21, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 22, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 23, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 24, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 25, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 26, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 27, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 28, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 29, Player1 = "move", MoveWin = false },
           new PlayerMove { Id = 30, Player1 = "Move", MoveWin = true });

            modelBuilder.Entity<GameList>().HasData( // agregar nombres de jugadores 
                new GameList { Id = 1, NumberOfMove = 1, GamesTotal = 3 },  
                new GameList { Id = 2, NumberOfMove = 2, GamesTotal = 4 },
                new GameList { Id = 3, NumberOfMove = 4, GamesTotal = 3 },
                new GameList { Id = 4, NumberOfMove = 6, GamesTotal = 8 },
                new GameList { Id = 5, NumberOfMove = 1, GamesTotal = 5 },
                new GameList { Id = 6, NumberOfMove = 1, GamesTotal = 3 },
                new GameList { Id = 7, NumberOfMove = 5, GamesTotal = 10 },
                new GameList { Id = 8, NumberOfMove = 1, GamesTotal = 6 },
                new GameList { Id = 9, NumberOfMove = 7, GamesTotal = 7 },
                new GameList { Id = 10, NumberOfMove = 1, GamesTotal = 9 },
                new GameList { Id = 11, NumberOfMove = 1, GamesTotal = 3 },
                new GameList { Id = 12, NumberOfMove = 8, GamesTotal = 6 },
                new GameList { Id = 13, NumberOfMove = 1, GamesTotal = 4 },
                new GameList { Id = 14, NumberOfMove = 1, GamesTotal = 3 },
                new GameList { Id = 15, NumberOfMove = 4, GamesTotal = 2 },
                new GameList { Id = 16, NumberOfMove = 1, GamesTotal = 1 },
                new GameList { Id = 17, NumberOfMove = 1, GamesTotal = 3 },
                new GameList { Id = 18, NumberOfMove = 3, GamesTotal = 3 },
                new GameList { Id = 19, NumberOfMove = 1, GamesTotal = 7 },
                new GameList { Id = 20, NumberOfMove = 1, GamesTotal = 3 },
                new GameList { Id = 21, NumberOfMove = 5, GamesTotal = 8 },
                new GameList { Id = 22, NumberOfMove = 1, GamesTotal = 3 },
                new GameList { Id = 23, NumberOfMove = 1, GamesTotal = 9 },
                new GameList { Id = 24, NumberOfMove = 2, GamesTotal = 3 },
                new GameList { Id = 25, NumberOfMove = 1, GamesTotal = 5 },
                new GameList { Id = 26, NumberOfMove = 1, GamesTotal = 6 },
                new GameList { Id = 27, NumberOfMove = 6, GamesTotal = 6 },
                new GameList { Id = 28, NumberOfMove = 1, GamesTotal = 3 },
                new GameList { Id = 29, NumberOfMove = 1, GamesTotal = 3 },
                new GameList { Id = 30, NumberOfMove = 1, GamesTotal = 3 });
            //  
        }
    }
}

//Created by Tatiana Alexandra Ramirez Madrigal 
using System;
using System.Text.Json.Serialization;

namespace APITicTacToe.Models
{                     
    public class GameList  
        
    {

        //Return a list of current running games (add to database)
        public int Id { get; set; }

        public int GamesTotal { get; set; }

        public int NumberOfMove { get; set; } 

        public virtual List<Game> Games { get; set; } 
      

    }
}


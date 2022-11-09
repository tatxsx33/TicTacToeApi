using System;
using System.Text.Json.Serialization;

namespace APITicTacToe.Models
{                     
    public class Game 
    {
        public int Id { get; set; }
        public string Player1 { get; set; } = string.Empty;  

        public string Player2 { get; set; } = string.Empty;
      
       [JsonIgnore] 
        public int PlayerMoveId { get; set; }
        
       public virtual PlayerMove? PlayerMove { get; set; } 
    }
}


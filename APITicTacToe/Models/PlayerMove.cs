using System;
namespace APITicTacToe.Models
{
    public class PlayerMove 
    {
        public int Id { get; set; } //player Id

        public string Player1 { get; set; } = string.Empty;

        public string Player2 { get; set; } = string.Empty;

        public bool MoveWin { get; set; } //

        public virtual List<Game>? Games { get; set; }  
        
      
    }
}


using APITicTacToe.Models;
using Microsoft.AspNetCore.Mvc;
//using System;

namespace APITicTacToe.Controllers; 

[ApiController]
[Route("api/[controller]")]

public class TestsController : ControllerBase  //starting game endpoint
{
    private readonly DataContext _context;


    public TestsController(DataContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }


//Returns a Player Id
 [HttpPost("Player.id ")]
   public async Task<ActionResult<Game>> PostGame(Game Game)
      {
      _context.Games.Add(Game);
        await _context.SaveChangesAsync() ;
        return CreatedAtAction(
               "GetProduct",
               new { id = Game.Id },
              Game);
     }


//-----------------------------------



}


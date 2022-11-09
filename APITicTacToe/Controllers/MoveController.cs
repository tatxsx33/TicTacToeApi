using APITicTacToe.Models;
using Microsoft.AspNetCore.Mvc;
//using System;

namespace APITicTacToe.Controllers;

[ApiController]
[Route("api/[controller]")]

public class MoveController : ControllerBase  //starting game endpoint
{
    private readonly DataContext _context;


    public MoveController(DataContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }


  

    //-------------------------------------------

    //ENDPOINT NUMBER 2  


    [HttpGet("playerId ")]   //RETURN A PLAYER ID 
    public ActionResult GetGame(int id)
    {

        var Game = _context.Games.Find(id);

        if (Game == null)
        {
            return NotFound();
        }

        return Ok(Game);

    }
}



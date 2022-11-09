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


    //1.Add and endpoint for Registered a player move ejemplo : Do you want to make a move? or click to make a move
    // 2.should take player ID and check for success or errors
    //3. should inform if the move wins the game

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



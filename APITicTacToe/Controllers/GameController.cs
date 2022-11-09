using APITicTacToe.Models;
using Microsoft.AspNetCore.Mvc;
//using System;

namespace APITicTacToe.Controllers; // 1st endpoint

[ApiController]
[Route("api/[controller]")]

public class StartGameController : ControllerBase  //starting game endpoint
{
    private readonly DataContext _context;


    public StartGameController(DataContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }

    //______________________________________________
   
    //This Request a player Id Return Player1 Name that the player chooses
    [HttpGet] [Route("/api/Player1")]
    public IActionResult PostPlayer1(string Player1) 
    {

    return Ok(Player1);
   
    }

//This Request a player Id Return Player2 name that the player chooses
 [HttpGet] [Route("/api/Player2")]
    public IActionResult PostPlayer2(string Player2) 
    {

    return Ok(Player2);
    
    }
}

    //--------------------------------------------





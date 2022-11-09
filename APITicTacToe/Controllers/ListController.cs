using APITicTacToe.Models;
using Microsoft.AspNetCore.Mvc;
//using System;

namespace APITicTacToe.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ListController : ControllerBase  //starting game endpoint
{
    private readonly DataContext _context;


    public ListController(DataContext context) // 3rd Endpoint
    {
        _context = context;
        _context.Database.EnsureCreated();
    }

    //ENDPOINT 3
    [HttpGet]  // list of Games
    public IEnumerable<GameList> GetList() 
    {
       
        return _context.GameLists.ToArray();

  }
   

}




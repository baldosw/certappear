using System.Diagnostics;
using CertofAppearance.Data;
using Microsoft.AspNetCore.Mvc;
using CertofAppearance.Models;

namespace CertofAppearance.Controllers;

using System.Data.SqlClient;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDBContext  _context;

 

    public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
    {
        _logger = logger;
        _context = context; 
    }
    public async Task<IActionResult> Index()
    {
        Client c = new Client();
        c.DateArrived = DateOnly.FromDateTime(DateTime.Now);
        c.DateReturned = DateOnly.FromDateTime(DateTime.Now.AddDays(1));
        
        return View(c);
    }
  
     // API -----------------


     [HttpPost("api/postclient")]
     public async Task<IActionResult> Index([FromBody] Client aClient)
     {
         try
         {
            
             if (ModelState.IsValid)
             {
                 await _context.Clients.AddAsync(aClient);
                 await _context.SaveChangesAsync();
                 return Ok(new { message = "Successfully added client" });
             }
             else
             {
                 var errors = ModelState.Keys
                     .Select(key => new
                     {
                         Field = key,
                         Error = ModelState[key].Errors.FirstOrDefault()?.ErrorMessage
                     })
                     .Where(item => item.Error != null)
                     .ToList();
              
                 var dataJson = new { success = false, errors = errors };
              
                 return BadRequest(dataJson);
             }
            
         }
         catch (Exception e)
         {
             return BadRequest(new { message = e.Message });
         }
        
     }
    

    public IActionResult Privacy()
    {
        
        return View();
    }
}
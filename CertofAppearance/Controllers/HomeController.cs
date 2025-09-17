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

    [BindProperty]
    public Client Client { get; set; }

    public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
    {
        _logger = logger;
        _context = context; 
    }
    public async Task<IActionResult> Index()
    {
        Client c = new Client();
        c.DateArrived =  DateOnly.FromDateTime(DateTime.Today);
        c.DateReturned =  DateOnly.FromDateTime(DateTime.Today.AddDays(1));
        return View(c);
    }
 
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(Client client)
    {
        if (ModelState.IsValid)
        {
            await _context.AddAsync(client);
            await _context.SaveChangesAsync();
            return View(client);
        }
        return View(new Client());
    }
    
    
    
     // API -----------------


     [HttpPost("api/postClient")]
     public async Task<IActionResult> Post([FromBody] Client client)
     {
         try
         {
             if (ModelState.IsValid)
             {
                 await _context.Clients.AddAsync(client);
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
                 string allErrors = string.Join("; ", errors);

// Example log
                 _logger.LogInformation("Validation errors: {Errors}", allErrors);
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
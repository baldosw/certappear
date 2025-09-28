using CertofAppearance.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CertofAppearance.Controllers;

public class SignatoryController : Controller
{
    private readonly ApplicationDBContext  _context;
 
    public SignatoryController(  ApplicationDBContext context)
    {
        _context = context; 
    }
        
    [HttpGet("api/signatory")]
    public async Task<IActionResult> GetAll()
    {
        var signatories = await _context.Signatories.ToListAsync();
        return Ok(signatories);
    }
}
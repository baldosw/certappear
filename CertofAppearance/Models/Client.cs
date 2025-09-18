using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CertofAppearance.Models;

public class Client
{
    [Key]
    public int Id
    {
        get;
        set;
    }
     
    [Required]
    [StringLength(50, MinimumLength =2 , ErrorMessage = "LGU must be between 2 and 50 characters.")]
    public string Lgu { get; set; }
  
    [Required]
    [StringLength(50, MinimumLength =2 , ErrorMessage = "FirstName must be between 2 and 50 characters.")]
    public string FirstName { get; set; }
    
    public string? MiddleInitial { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength =2 , ErrorMessage = "LastName must be between 2 and 50 characters.")]
    public string LastName { get; set; }
 
    [Required]
    [StringLength(50, MinimumLength =2 , ErrorMessage = "Position must be between 2 and 50 characters.")]
    public string Position { get; set; }
 
    [Required]
    [StringLength(50, MinimumLength =2 , ErrorMessage = "Purpose must be between 2 and 50 characters.")]
    public string Purpose { get; set; }
     
   
}
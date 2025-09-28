using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;
using CertofAppearance.Common;
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
    
    [Required]
    public DateOnly DateArrived { get; set; }
    
    [Required]
    public DateOnly DateReturned { get; set; }

    public string Gender { get; set; }
     
    public DateOnly DateCreated { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    
    public string? Pronoun { get; set; }
    
    public string? Prefix { get; set; }

    public int? SignatoryId { get; set; }
    
    public Signatory? Signatory { get; set; }
}
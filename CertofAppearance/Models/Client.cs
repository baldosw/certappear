using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace CertofAppearance.Models;

public class Client
{
    [Key]
    private int _id;
    private string _firstName;
    private string _lastName;
    private string _position;
    private string _lgu;
    private DateOnly _dateArrived;
    private DateOnly _dateReturned;
    private string _purpose;

    public int Id
    {
        get => _id;
        set => _id = value;
    }
    
    [Display(Name = "First Name")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 50 characters.")]
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    [Display(Name = "Middle Initial")]
    public string? MiddleInitial { get; set; }

    [Display(Name = "Last Name")]

    [StringLength(50, MinimumLength = 2, ErrorMessage = "Last Name must be between 2 and 50 characters.")]
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    [Display(Name = "Position")]

    [StringLength(50, MinimumLength = 2, ErrorMessage = "Position must be between 2 and 50 characters.")]
    public string Position
    {
        get => _position;
        set => _position = value;
    }

    [Display(Name = "LGU")]

    [StringLength(50, MinimumLength = 2, ErrorMessage = "LGU must be between 2 and 50 characters.")]
    public string Lgu
    {
        get => _lgu;
        set => _lgu = value;
    }

    [Required]
    [Display(Name = "Date Arrived")]

    public DateOnly DateArrived
    {
        get => _dateArrived;
        set => _dateArrived = value;
    }

    [Required]
    [Display(Name = "Date Returned")]

    public DateOnly DateReturned
    {
        get => _dateReturned;
        set => _dateReturned = value;
    }

    [Display(Name = "Purpose")]

    [StringLength(500, MinimumLength = 4, ErrorMessage = "Purpose must be between 2 and 500 characters.")]
    public string Purpose
    {
        get => _purpose;
        set => _purpose = value;
    }
}
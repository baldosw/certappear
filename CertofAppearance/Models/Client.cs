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
    [StringLength(50, MinimumLength = 2, ErrorMessage = "FirstName must be between 2 and 50 characters.")]
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string MiddileInitial { get; set; }

    [StringLength(50, MinimumLength = 2, ErrorMessage = "LastName must be between 2 and 50 characters.")]
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    [StringLength(50, MinimumLength = 2, ErrorMessage = "Position must be between 2 and 50 characters.")]
    public string Position
    {
        get => _position;
        set => _position = value;
    }

    [StringLength(50, MinimumLength = 2, ErrorMessage = "LGU must be between 2 and 50 characters.")]
    public string Lgu
    {
        get => _lgu;
        set => _lgu = value;
    }

    [Required]
    public DateOnly DateArrived
    {
        get => _dateArrived;
        set => _dateArrived = value;
    }

    [Required]
    public DateOnly DateReturned
    {
        get => _dateReturned;
        set => _dateReturned = value;
    }

    [StringLength(500, MinimumLength = 4, ErrorMessage = "Purpose must be between 2 and 500 characters.")]
    public string Purpose
    {
        get => _purpose;
        set => _purpose = value;
    }
}
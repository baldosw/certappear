using System.ComponentModel.DataAnnotations;

namespace CertofAppearance.Models;

public class Signatory
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
}
using CertofAppearance.Models;
using Microsoft.EntityFrameworkCore;

namespace CertofAppearance.Data;

public class ApplicationDBContext :DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }
    
    public DbSet<Client> Clients { get; set; }

}   
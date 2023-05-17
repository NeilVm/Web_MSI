using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web_MSI.Models;

namespace Web_MSI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<Web_MSI.Models.HojaRegistroD> DataRegistro { get; set; }
         public DbSet<Web_MSI.Models.Penalidades> DataPenalidades { get; set; }
    }
}

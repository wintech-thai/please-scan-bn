using Microsoft.EntityFrameworkCore;
using Its.PleaseScan.Api.Models;

namespace Its.PleaseScan.Api.Database
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();
        public DbSet<MOrganization>? Organizations { get; set; }
        public DbSet<MApiKey>? ApiKeys { get; set; }
        public DbSet<MRole>? Roles { get; set; }
        public DbSet<MUser>? Users { get; set; }
        public DbSet<MOrganizationUser>? OrganizationUsers { get; set; }
    }
}
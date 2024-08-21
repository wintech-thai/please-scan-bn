namespace Its.PleaseScan.Api.Database;

using Its.PleaseScan.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
public class DataContext : DbContext, IDataContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration, DbContextOptions<DataContext> options) : base(options)
    {
        Configuration = configuration;
    }

    public DbSet<MOrganization>? Organizations { get; set; }
    public DbSet<MApiKey>? ApiKeys { get; set; }
    public DbSet<MRole>? Roles { get; set; }
    public DbSet<MUser>? Users { get; set; }
    public DbSet<MOrganizationUser>? OrganizationUsers { get; set; }
    public DbSet<MWorkflowTemplate>? WorkflowTemplates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MOrganization>();
        modelBuilder.Entity<MApiKey>();
        modelBuilder.Entity<MRole>();
        modelBuilder.Entity<MUser>();
        modelBuilder.Entity<MOrganizationUser>();
        modelBuilder.Entity<MWorkflowTemplate>();
    }
}

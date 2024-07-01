using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataBaseWebApp.Data;

public class DataBaseWebAppContext(DbContextOptions<DataBaseWebAppContext> options) : IdentityDbContext<DataBaseAppContextUser>(options)
{
    public DbSet<Models.Company> Company { get; init; } = default!;
    public DbSet<Models.LoadCell> LoadCell { get; init; } = default!;
}
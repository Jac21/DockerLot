using Microsoft.EntityFrameworkCore;

namespace DockerDotNetSix.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
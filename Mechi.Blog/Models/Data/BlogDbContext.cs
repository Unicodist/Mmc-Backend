using Mechi.Backend.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Mechi.Backend.Models.Data;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UserMaster> UserMasters { get; set; }
    public DbSet<UserCredentials> UserCredentials { get; set; }
}
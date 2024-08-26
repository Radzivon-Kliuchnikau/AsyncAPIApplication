using AsyncAPIApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AsyncAPIApplication.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<ListOfRequests> Requests => Set<ListOfRequests>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
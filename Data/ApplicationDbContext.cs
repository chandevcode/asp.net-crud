using System;
using Microsoft.EntityFrameworkCore;
using MVCCRUD.Models.Domain;

namespace MVCCRUD.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }
  }
}


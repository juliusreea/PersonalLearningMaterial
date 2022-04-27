using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkRelations.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkRelations.Data;

public class BrickContext : DbContext
{

    public DbSet<Brick> Bricks { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<BrickAvailability> BrickAvailabilities { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=localhost;Database=Bricks;Trusted_Connection=True;");
}

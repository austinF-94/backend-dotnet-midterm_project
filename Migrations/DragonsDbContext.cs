using midterm_project.Models;
using Microsoft.EntityFrameworkCore;

namespace midterm_project.Migrations;

public class DragonsDbContext : DbContext 
{
    public DbSet<Dragons> Dragons { get; set; }

    public DragonsDbContext(DbContextOptions<DragonsDbContext> options)
    : base(options)
{
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Dragons>(entity =>
    {
        entity.HasKey(e => e.DragonId);
        entity.Property(e => e.dragonName).IsRequired();
        entity.Property(e => e.dragonImage).IsRequired();
        entity.Property(e => e.dragonDescription).IsRequired();
        entity.Property(e => e.dragonDetails).IsRequired();

    });
}
}


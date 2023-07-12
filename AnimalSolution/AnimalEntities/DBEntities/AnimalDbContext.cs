using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AnimalEntities.DBEntities;

public partial class AnimalDbContext : DbContext
{
    public AnimalDbContext()
    {
    }

    public AnimalDbContext(DbContextOptions<AnimalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Animal> Animals { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>(entity =>
        {
            entity.ToTable("Animal");

            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.Breed).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Sex).HasMaxLength(1);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

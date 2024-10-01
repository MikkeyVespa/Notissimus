using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Notiss.Models;

public partial class DbContextNotiss : DbContext
{
    public DbContextNotiss()
    {
    }

    public DbContextNotiss(DbContextOptions<DbContextNotiss> options)
        : base(options)
    {
    }

    public virtual DbSet<Coordinate> Coordinates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=Test;Integrated Security=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coordinate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Coordina__3214EC07E4C31EA0");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

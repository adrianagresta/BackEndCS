using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Models;

public partial class JatfniContext : DbContext
{
    public JatfniContext(DbContextOptions<JatfniContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Application> Applications { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("application_pkey");

            entity.ToTable("application", "appdat");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Applied).HasColumnName("applied");
            entity.Property(e => e.Applydate).HasColumnName("applydate");
            entity.Property(e => e.Company).HasColumnName("company");
            entity.Property(e => e.Link).HasColumnName("link");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Rejectdate).HasColumnName("rejectdate");
            entity.Property(e => e.Rejected).HasColumnName("rejected");
            entity.Property(e => e.Salarymax).HasColumnName("salarymax");
            entity.Property(e => e.Salarymin).HasColumnName("salarymin");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

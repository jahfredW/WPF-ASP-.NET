using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using gestion_de_stocks.Models.Data;

namespace gestion_de_stocks.Models;

public partial class stockContext : DbContext
{
    public stockContext()
    {
    }

    public stockContext(DbContextOptions<stockContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Typesproduit> Typesproduits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("Server=localhost;Database=stock;user=root;password=");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.IdArticles).HasName("PRIMARY");

            entity.ToTable("articles");

            entity.HasIndex(e => e.IdCategories, "FK_CATEGORIES");

            entity.Property(e => e.IdArticles).HasColumnName("Id_Articles");
            entity.Property(e => e.IdCategories).HasColumnName("Id_Categories");
            entity.Property(e => e.LibelleArticle).HasMaxLength(100);

            entity.HasOne(d => d.LaCategorie).WithMany(p => p.Articles)
                .HasForeignKey(d => d.IdCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CATEGORIES");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategories).HasName("PRIMARY");

            entity.ToTable("categories");

            entity.HasIndex(e => e.IdTypesProduits, "FK_TYPE_PRODUITS");

            entity.Property(e => e.IdCategories).HasColumnName("Id_Categories");
            entity.Property(e => e.IdTypesProduits).HasColumnName("Id_TypesProduits");
            entity.Property(e => e.LibelleCategorie).HasMaxLength(50);

            entity.HasOne(d => d.LeTypeProduit).WithMany(p => p.Categories)
                .HasForeignKey(d => d.IdTypesProduits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TYPE_PRODUITS");
        });

        modelBuilder.Entity<Typesproduit>(entity =>
        {
            entity.HasKey(e => e.IdTypesProduits).HasName("PRIMARY");

            entity.ToTable("typesproduits");

            entity.Property(e => e.IdTypesProduits).HasColumnName("Id_TypesProduits");
            entity.Property(e => e.LibelleTypeProduit).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

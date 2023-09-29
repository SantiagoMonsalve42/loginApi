using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace datos.modelo;

public partial class SpDbContext : DbContext
{
    public SpDbContext()
    {
    }

    public SpDbContext(DbContextOptions<SpDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblUsuario> TblUsuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblUsuario>(entity =>
        {
            entity.ToTable("TBL_USUARIO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOCUMENTO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.TipoIdDocumento).HasColumnName("TIPO_ID_DOCUMENTO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

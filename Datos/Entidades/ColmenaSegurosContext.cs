using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Datos.Entidades;

public partial class ColmenaSegurosContext : DbContext
{
    public ColmenaSegurosContext()
    {
    }

    public ColmenaSegurosContext(DbContextOptions<ColmenaSegurosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adquisicione> Adquisiciones { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Cotizacione> Cotizaciones { get; set; }

    public virtual DbSet<Poliza> Polizas { get; set; }

    public virtual DbSet<Seguro> Seguros { get; set; }

    public virtual DbSet<Siniestro> Siniestros { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adquisicione>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Estado)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Adquisiciones)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_Adquisiciones_Cliente");

            entity.HasOne(d => d.IdPolizaNavigation).WithMany(p => p.Adquisiciones)
                .HasForeignKey(d => d.IdPoliza)
                .HasConstraintName("FK_Adquisiciones_Polizas");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("Cliente");

            entity.Property(e => e.Contraseña)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cotizacione>(entity =>
        {
            entity.Property(e => e.Monto)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Cotizaciones)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_Cotizaciones_Cliente");

            entity.HasOne(d => d.IdPolizaNavigation).WithMany(p => p.Cotizaciones)
                .HasForeignKey(d => d.IdPoliza)
                .HasConstraintName("FK_Cotizaciones_Polizas");
        });

        modelBuilder.Entity<Poliza>(entity =>
        {
            entity.Property(e => e.Cobertura)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Condiciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Prima)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSeguroNavigation).WithMany(p => p.Polizas)
                .HasForeignKey(d => d.IdSeguro)
                .HasConstraintName("FK_Polizas_Seguros");
        });

        modelBuilder.Entity<Seguro>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(250);
        });

        modelBuilder.Entity<Siniestro>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAdquisicionNavigation).WithMany(p => p.Siniestros)
                .HasForeignKey(d => d.IdAdquisicion)
                .HasConstraintName("FK_Siniestros_Adquisiciones");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.Property(e => e.Contaseña)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

﻿// <auto-generated />
using System;
using MascotaFeliz.app.Persistencia.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotaFeliz.app.Persistencia.Migrations
{
    [DbContext(typeof(EfAppContext))]
    partial class EfAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.CentroVeterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Direccion");

                    b.Property<int>("Nit")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("Nit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.ToTable("CentroVeterinario");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("ColorOjos")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColorOjos");

                    b.Property<string>("ColorPiel")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColorPiel");

                    b.Property<int>("Estatura")
                        .HasColumnType("int")
                        .HasColumnName("Estatura");

                    b.Property<int>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoAnimal")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<int>("Peso")
                        .HasColumnType("int")
                        .HasColumnName("Peso");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Raza");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Sexo");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoAnimal");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Apellido");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("DocumentoIdentidad");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.RegistroVisita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoAnimo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EstadoAnimo");

                    b.Property<int>("FrecuenciaCardiaca")
                        .HasColumnType("int")
                        .HasColumnName("FrecuenciaCardiaca");

                    b.Property<int>("FrecuenciaRespiratoria")
                        .HasColumnType("int")
                        .HasColumnName("FrecuenciaRespiratoria");

                    b.Property<int>("IdVisitaProgramada")
                        .HasColumnType("int");

                    b.Property<string>("Medicamentos")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Medicamentos");

                    b.Property<int>("Peso")
                        .HasColumnType("int")
                        .HasColumnName("Peso");

                    b.Property<string>("Recomendacion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Recomendacion");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int")
                        .HasColumnName("Temperatura");

                    b.HasKey("Id");

                    b.ToTable("RegistroVisita");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.TipoAnimal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Animal");

                    b.HasKey("Id");

                    b.ToTable("TipoAnimal");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.VisitaProgramada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha");

                    b.Property<int>("IdMascota")
                        .HasColumnType("int");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoAnimal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoAnimal");

                    b.ToTable("VisitaProgramada");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.Medico", b =>
                {
                    b.HasBaseType("MascotaFeliz.app.Dominio.Entidades.Persona");

                    b.Property<int>("IdCentroVeterinario")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoAnimal")
                        .HasColumnType("int");

                    b.Property<int>("TarjetaProfesional")
                        .HasColumnType("int")
                        .HasColumnName("TarjetaProfesional");

                    b.HasIndex("IdTipoAnimal");

                    b.ToTable("Persona");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.Propietario", b =>
                {
                    b.HasBaseType("MascotaFeliz.app.Dominio.Entidades.Persona");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Direccion");

                    b.ToTable("Persona");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.Mascota", b =>
                {
                    b.HasOne("MascotaFeliz.app.Dominio.Entidades.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdTipoAnimal");

                    b.Navigation("TipoAnimal");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.VisitaProgramada", b =>
                {
                    b.HasOne("MascotaFeliz.app.Dominio.Entidades.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdTipoAnimal");

                    b.Navigation("TipoAnimal");
                });

            modelBuilder.Entity("MascotaFeliz.app.Dominio.Entidades.Medico", b =>
                {
                    b.HasOne("MascotaFeliz.app.Dominio.Entidades.TipoAnimal", "Especializacion")
                        .WithMany()
                        .HasForeignKey("IdTipoAnimal");

                    b.Navigation("Especializacion");
                });
#pragma warning restore 612, 618
        }
    }
}

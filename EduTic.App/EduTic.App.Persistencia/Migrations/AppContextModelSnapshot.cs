﻿// <auto-generated />
using System;
using EduTic.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EduTic.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EduTic.App.Dominio.Actividad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte[]>("archivoE")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("archivoP")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("materiasid")
                        .HasColumnType("int");

                    b.Property<string>("nombreActividad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("nota")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("materiasid");

                    b.ToTable("Actividad");
                });

            modelBuilder.Entity("EduTic.App.Dominio.Materia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("EduTic.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("grado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("EduTic.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("EduTic.App.Dominio.Persona");

                    b.Property<string>("codigoEstudiante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("materiaEid")
                        .HasColumnType("int");

                    b.HasIndex("materiaEid");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("EduTic.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("EduTic.App.Dominio.Persona");

                    b.Property<string>("cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("materiaPid")
                        .HasColumnType("int");

                    b.HasIndex("materiaPid");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("EduTic.App.Dominio.Actividad", b =>
                {
                    b.HasOne("EduTic.App.Dominio.Materia", "materias")
                        .WithMany()
                        .HasForeignKey("materiasid");

                    b.Navigation("materias");
                });

            modelBuilder.Entity("EduTic.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("EduTic.App.Dominio.Materia", "materiaE")
                        .WithMany()
                        .HasForeignKey("materiaEid");

                    b.Navigation("materiaE");
                });

            modelBuilder.Entity("EduTic.App.Dominio.Profesor", b =>
                {
                    b.HasOne("EduTic.App.Dominio.Materia", "materiaP")
                        .WithMany()
                        .HasForeignKey("materiaPid");

                    b.Navigation("materiaP");
                });
#pragma warning restore 612, 618
        }
    }
}

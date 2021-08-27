﻿// <auto-generated />
using System;
using ClienteDemo.Infrastucture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClienteDemo.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210826193338_MakeClienteUnique")]
    partial class MakeClienteUnique
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClienteDemo.Infrastucture.Models.ClienteModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Cliente")
                        .IsUnique()
                        .HasFilter("[Cliente] IS NOT NULL");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}

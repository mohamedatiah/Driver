﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransfloDriver.Data;

#nullable disable

namespace TransfloDriver.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230302180953_intial")]
    partial class intial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransfloDriver.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Shabaneita@gmail.com",
                            FirstName = "Shaaban",
                            LastName = "Eita",
                            Password = "test",
                            PhoneNumber = "+201116039373"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Shabaneita@gmail.com",
                            FirstName = "Premium Pool Driver",
                            LastName = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Password = "test",
                            PhoneNumber = "+201116039373"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Shabaneita@gmail.com",
                            FirstName = "Luxury Pool Driver",
                            LastName = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Password = "test",
                            PhoneNumber = "+201116039373"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Shabaneita@gmail.com",
                            FirstName = "Diamond Driver",
                            LastName = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Password = "test",
                            PhoneNumber = "+201116039373"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Shabaneita@gmail.com",
                            FirstName = "Diamond Pool Driver",
                            LastName = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Password = "test",
                            PhoneNumber = "+201116039373"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

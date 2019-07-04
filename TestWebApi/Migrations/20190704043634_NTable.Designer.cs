﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestWebApi.Models;

namespace TestWebApi.Migrations
{
    [DbContext(typeof(BAZAContext))]
    [Migration("20190704043634_NTable")]
    partial class NTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestWebApi.Models.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId");

                    b.Property<int>("Contact_Phone");

                    b.Property<int>("Count");

                    b.Property<int>("Count_Show");

                    b.Property<int>("CountryId");

                    b.Property<string>("Decription");

                    b.Property<int>("Engine_CapacityId");

                    b.Property<int>("KindId");

                    b.Property<int>("ManufactureID");

                    b.Property<string>("Name_Model");

                    b.Property<DateTime>("Push_time");

                    b.Property<int>("Release_year");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("Engine_CapacityId");

                    b.HasIndex("KindId");

                    b.HasIndex("ManufactureID");

                    b.HasIndex("UserId");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("TestWebApi.Models.Bike_Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BikeId");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.HasIndex("BikeId");

                    b.ToTable("Bike_Photos");
                });

            modelBuilder.Entity("TestWebApi.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("TestWebApi.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TestWebApi.Models.Engine_Capacity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Engine_Capacities");
                });

            modelBuilder.Entity("TestWebApi.Models.Kind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Kinds");
                });

            modelBuilder.Entity("TestWebApi.Models.Manufacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Manufactures");
                });

            modelBuilder.Entity("TestWebApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Gender");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Telephone_number");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TestWebApi.Models.User_Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("User_Photo");
                });

            modelBuilder.Entity("TestWebApi.Models.Bike", b =>
                {
                    b.HasOne("TestWebApi.Models.City")
                        .WithMany("List_Bike")
                        .HasForeignKey("CityId");

                    b.HasOne("TestWebApi.Models.Country", "Country")
                        .WithMany("List_Bike")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestWebApi.Models.Engine_Capacity", "Engine_Capacity")
                        .WithMany("List_Bike")
                        .HasForeignKey("Engine_CapacityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestWebApi.Models.Kind", "Kind")
                        .WithMany("List_Bike")
                        .HasForeignKey("KindId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestWebApi.Models.Manufacture", "Manufacture")
                        .WithMany("List_Bike")
                        .HasForeignKey("ManufactureID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestWebApi.Models.User", "User")
                        .WithMany("User_List_Bike")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestWebApi.Models.Bike_Photo", b =>
                {
                    b.HasOne("TestWebApi.Models.Bike", "bike")
                        .WithMany("Photos")
                        .HasForeignKey("BikeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestWebApi.Models.User_Photo", b =>
                {
                    b.HasOne("TestWebApi.Models.User", "User")
                        .WithOne("User_Photo")
                        .HasForeignKey("TestWebApi.Models.User_Photo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

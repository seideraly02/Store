﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Models;

namespace Store.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Store.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Store.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PhoneId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Store.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BrandId1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BrandIdId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("BrandId1");

                    b.HasIndex("BrandIdId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("Store.Models.Order", b =>
                {
                    b.HasOne("Store.Models.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Store.Models.Phone", b =>
                {
                    b.HasOne("Store.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId1");

                    b.HasOne("Store.Models.Brand", "BrandId")
                        .WithMany()
                        .HasForeignKey("BrandIdId");
                });
#pragma warning restore 612, 618
        }
    }
}

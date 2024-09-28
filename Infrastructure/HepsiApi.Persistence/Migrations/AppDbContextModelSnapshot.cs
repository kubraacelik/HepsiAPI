﻿// <auto-generated />
using System;
using HepsiApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HepsiApi.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("HepsiApi.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 397, DateTimeKind.Local).AddTicks(9322),
                            IsDeleted = false,
                            Name = "Games"
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 397, DateTimeKind.Local).AddTicks(9334),
                            IsDeleted = false,
                            Name = "Health"
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 397, DateTimeKind.Local).AddTicks(9340),
                            IsDeleted = true,
                            Name = "Tools"
                        });
                });

            modelBuilder.Entity("HepsiApi.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 398, DateTimeKind.Local).AddTicks(1562),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 398, DateTimeKind.Local).AddTicks(1564),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 398, DateTimeKind.Local).AddTicks(1566),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 398, DateTimeKind.Local).AddTicks(1606),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("HepsiApi.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 400, DateTimeKind.Local).AddTicks(2687),
                            Description = "Odit filmini tv şafak cesurca.",
                            IsDeleted = false,
                            Title = "Molestiae."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 400, DateTimeKind.Local).AddTicks(2783),
                            Description = "Nostrum için qui odit et.",
                            IsDeleted = true,
                            Title = "Çobanın voluptatem."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 400, DateTimeKind.Local).AddTicks(2827),
                            Description = "Odit aut enim yazın aspernatur.",
                            IsDeleted = false,
                            Title = "Quis."
                        });
                });

            modelBuilder.Entity("HepsiApi.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discound")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 402, DateTimeKind.Local).AddTicks(7380),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Discound = 6.466751345638470m,
                            IsDeleted = false,
                            Price = 685.17m,
                            Title = "Fantastic Concrete Mouse"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedTime = new DateTime(2024, 9, 28, 9, 5, 54, 402, DateTimeKind.Local).AddTicks(7408),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Discound = 8.941032626999940m,
                            IsDeleted = false,
                            Price = 13.08m,
                            Title = "Handcrafted Steel Pants"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("HepsiApi.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HepsiApi.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HepsiApi.Domain.Entities.Detail", b =>
                {
                    b.HasOne("HepsiApi.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HepsiApi.Domain.Entities.Product", b =>
                {
                    b.HasOne("HepsiApi.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("HepsiApi.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task.Model.ORM;

#nullable disable

namespace Task.Migrations
{
    [DbContext(typeof(TaskDBContext))]
    partial class TaskDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Task.Model.Product", b =>
                {
                    b.Property<long>("ProductStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductStatusId"), 1L, 1);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionDomestic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasPersonalization")
                        .HasColumnType("bit");

                    b.Property<bool>("HasVideo")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDigital")
                        .HasColumnType("bit");

                    b.Property<bool>("IsElonkyFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTaxable")
                        .HasColumnType("bit");

                    b.Property<string>("OtherCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalizationDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceDiscounted")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceDiscountedDomestic")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleDomestic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhenMade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoMade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductStatusId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

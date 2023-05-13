﻿// <auto-generated />
using EastNeticApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EastNeticApp.Server.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230513080238_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EastNeticApp.Shared.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("EastNeticApp.Shared.Model.OrderElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ElementName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TotalSubElement")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderElement");
                });

            modelBuilder.Entity("EastNeticApp.Shared.Model.OrderSubElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("Height")
                        .HasColumnType("float");

                    b.Property<int>("OrderElementId")
                        .HasColumnType("int");

                    b.Property<int>("OrderTypeId")
                        .HasColumnType("int");

                    b.Property<float>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("OrderSubElement");
                });
#pragma warning restore 612, 618
        }
    }
}

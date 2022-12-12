﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhongHienCoop.data;

#nullable disable

namespace PhongHienCoop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221212080912_Innittial")]
    partial class Innittial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PhongHienCoop.Models.Admin", b =>
                {
                    b.Property<int>("acc_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("acc_id"));

                    b.Property<string>("acc_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acc_log_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("acc_name")
                        .HasColumnType("int");

                    b.Property<int>("acc_pass")
                        .HasColumnType("int");

                    b.Property<int>("acc_tel")
                        .HasColumnType("int");

                    b.HasKey("acc_id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PhongHienCoop.Models.Customer", b =>
                {
                    b.Property<int>("agent_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("agent_id"));

                    b.Property<string>("agent_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("agent_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("agent_pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("agent_tel")
                        .HasColumnType("int");

                    b.HasKey("agent_id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("PhongHienCoop.Models.Product", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("product_id"));

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("product_id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}

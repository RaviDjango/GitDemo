﻿// <auto-generated />
using System;
using Invoicing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DigiTrade.Invoicing.Migrations
{
    [DbContext(typeof(InvoiceDbContext))]
    partial class InvoiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
          
            modelBuilder.Entity("Invoicing.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128).IsUnicode(true);
                        b.HasIndex().IsUnique();

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });
            
  

            modelBuilder.Entity("Invoicing.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cust_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Cust_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Cust_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Cust_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Invoicing.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<short>("Ram")
                        .HasColumnType("smallint");

                    b.Property<short>("Rom")
                        .HasColumnType("smallint");

                    b.Property<short>("battery")
                        .HasColumnType("smallint");

                    b.Property<long>("cur_stock")
                        .HasColumnType("bigint");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<byte>("front_cam")
                        .HasColumnType("tinyint");

                    b.Property<byte>("primary_cam")
                        .HasColumnType("tinyint");

                    b.Property<string>("processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<long>("sale_price")
                        .HasColumnType("bigint");

                    b.Property<byte?>("tax")
                        .HasColumnType("tinyint");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Invoicing.Models.SalesInvoice", b =>
                {
                    b.Property<int>("Invoice_num")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cust_ID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Invoice_Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<long>("Rate")
                        .HasColumnType("bigint");

                    b.HasKey("Invoice_num");

                    b.HasIndex("Cust_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("SalesInvoices");
                });

            modelBuilder.Entity("Invoicing.Models.Product", b =>
                {
                    b.HasOne("Invoicing.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("Invoicing.Models.SalesInvoice", b =>
                {
                    b.HasOne("Invoicing.Models.Customer", "Customers")
                        .WithMany()
                        .HasForeignKey("Cust_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Invoicing.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using CustomerService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerService.Migrations
{
    [DbContext(typeof(CustomerServiceContext))]
    partial class CustomerServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BusinessObjects.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CustomerCity")
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerCountry")
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerName")
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerZipCode")
                        .HasColumnType("longtext");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}

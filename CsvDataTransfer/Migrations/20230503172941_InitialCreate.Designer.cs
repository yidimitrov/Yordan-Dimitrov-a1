﻿// <auto-generated />
using CsvDataTransfer.Processing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CsvDataTransfer.Migrations
{
    [DbContext(typeof(CsvDbContext))]
    [Migration("20230503172941_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("CsvDataTransfer.Models.OfferDbModel", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CancelledContractsForMonth")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("MonthlyFee")
                        .HasColumnType("TEXT");

                    b.Property<int>("NewContractsForMonth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SameContractsForMonth")
                        .HasColumnType("INTEGER");

                    b.HasKey("OfferId");

                    b.ToTable("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}

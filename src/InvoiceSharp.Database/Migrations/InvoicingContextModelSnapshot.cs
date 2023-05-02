﻿// <auto-generated />
using System;
using InvoiceSharp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvoiceSharp.Database.Migrations
{
    [DbContext(typeof(InvoicingContext))]
    partial class InvoicingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("InvoiceSharp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VatNumberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerId");

                    b.HasIndex("VatNumberId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InvoiceSharp.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("InvoiceSharp.Models.VatNumber", b =>
                {
                    b.Property<int>("VatNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ZoneId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VatNumberId");

                    b.HasIndex("ZoneId");

                    b.ToTable("VatNumbers");
                });

            modelBuilder.Entity("InvoiceSharp.Models.VatZone", b =>
                {
                    b.Property<int>("VatZoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Rate")
                        .HasColumnType("TEXT");

                    b.HasKey("VatZoneId");

                    b.ToTable("VatZones");
                });

            modelBuilder.Entity("InvoiceSharp.Models.Customer", b =>
                {
                    b.HasOne("InvoiceSharp.Models.VatNumber", "VatNumber")
                        .WithMany()
                        .HasForeignKey("VatNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VatNumber");
                });

            modelBuilder.Entity("InvoiceSharp.Models.Invoice", b =>
                {
                    b.HasOne("InvoiceSharp.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("InvoiceSharp.Models.VatNumber", b =>
                {
                    b.HasOne("InvoiceSharp.Models.VatZone", "Zone")
                        .WithMany("VatNumbers")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("InvoiceSharp.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("InvoiceSharp.Models.VatZone", b =>
                {
                    b.Navigation("VatNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}

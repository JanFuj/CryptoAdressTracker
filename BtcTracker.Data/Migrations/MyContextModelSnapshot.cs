﻿// <auto-generated />
using System;
using BtcTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BtcTracker.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BtcTracker.Data.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CryptoAddress")
                        .IsRequired();

                    b.Property<int?>("CurrencyID");

                    b.Property<string>("Label");

                    b.Property<double?>("UsdValue");

                    b.Property<double?>("Value");

                    b.HasKey("ID");

                    b.HasIndex("CurrencyID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BtcTracker.Data.Models.Currency", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("BtcTracker.Data.Models.Address", b =>
                {
                    b.HasOne("BtcTracker.Data.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyID");
                });
#pragma warning restore 612, 618
        }
    }
}

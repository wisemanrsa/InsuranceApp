﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using insuranceApp.Models;

namespace insuranceApp.Migrations
{
    [DbContext(typeof(InsuranceDbContext))]
    [Migration("20190712142035_AddActionDate")]
    partial class AddActionDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InsuranceApp.Models.PremiumsHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActionDate");

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.Property<int>("PayerId");

                    b.Property<int>("SumInsured");

                    b.HasKey("Id");

                    b.ToTable("PremiumsHistories");
                });

            modelBuilder.Entity("insuranceApp.Models.OtherPremium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Field18_25");

                    b.Property<int>("Field26_40");

                    b.Property<int>("Field41_45");

                    b.Property<int>("Field46_50");

                    b.Property<int>("Field51_55");

                    b.Property<int>("Field56_60");

                    b.Property<int>("Field61_65");

                    b.Property<int>("SumInsured");

                    b.HasKey("Id");

                    b.ToTable("OtherPremiums");
                });

            modelBuilder.Entity("insuranceApp.Models.OwnPremium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Field18_25");

                    b.Property<int>("Field26_40");

                    b.Property<int>("Field41_45");

                    b.Property<int>("Field46_50");

                    b.Property<int>("Field51_55");

                    b.Property<int>("Field56_60");

                    b.Property<int>("Field61_65");

                    b.Property<int>("SumInsured");

                    b.HasKey("Id");

                    b.ToTable("OwnPremiums");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Omisrho.Infrastrucutre.EntityFrameworkCore;

#nullable disable

namespace Omisrho.Infrastrucutre.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220624001715_FirstDataSeed")]
    partial class FirstDataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Omisrho.Domain.Entities.Fault_Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EqiupmentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaultCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaultStatusConfirmed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fault_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LaneDirection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LaneNumber")
                        .HasColumnType("int");

                    b.Property<string>("LaneStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlazaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fault_Notifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = new Guid("fdc36b12-9de0-407a-845d-9cc3e2a59149"),
                            CreatedOn = new DateTime(2022, 6, 24, 1, 17, 14, 953, DateTimeKind.Local).AddTicks(7599),
                            EqiupmentType = "Boom Barrier",
                            FaultCategory = "Critical Error",
                            FaultStatusConfirmed = "Fault Status Pending.",
                            Fault_Description = "Boom Barrier not opening for user after classification and validation and traffic turn Green.",
                            IsDeleted = false,
                            LaneDirection = "EB",
                            LaneNumber = 7,
                            LaneStatus = "Lane Closed",
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedOn = new DateTime(2022, 6, 24, 1, 17, 14, 953, DateTimeKind.Local).AddTicks(7611),
                            PlazaName = "Admiralty Plaza"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = new Guid("f911de87-0250-405d-ae3d-368f61e849c6"),
                            CreatedOn = new DateTime(2022, 6, 24, 1, 17, 14, 953, DateTimeKind.Local).AddTicks(7696),
                            EqiupmentType = "Traffic Ligth Green",
                            FaultCategory = "Major Error",
                            FaultStatusConfirmed = "Fault Status Pending.",
                            Fault_Description = "Traffic Light Greeen",
                            IsDeleted = false,
                            LaneDirection = "EB",
                            LaneNumber = 10,
                            LaneStatus = "Lane Closed",
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedOn = new DateTime(2022, 6, 24, 1, 17, 14, 953, DateTimeKind.Local).AddTicks(7697),
                            PlazaName = "Admiralty Plaza"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

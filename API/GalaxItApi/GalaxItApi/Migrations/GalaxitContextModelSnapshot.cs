﻿// <auto-generated />
using System;
using GalaxItApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GalaxItApi.Migrations
{
    [DbContext(typeof(GalaxitContext))]
    partial class GalaxitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GalaxItApi.Models.Bubble", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Atmosphere")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Bubble");
                });

            modelBuilder.Entity("GalaxItApi.Models.Seat", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("End");

                    b.Property<bool>("Occupied");

                    b.Property<DateTime>("Start");

                    b.Property<string>("TableId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("GalaxItApi.Models.Table", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BubbleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BubbleId");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("GalaxItApi.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Firstname")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("SeatId");

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SeatId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GalaxItApi.Models.Seat", b =>
                {
                    b.HasOne("GalaxItApi.Models.Table", "Table")
                        .WithMany("Seats")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GalaxItApi.Models.Table", b =>
                {
                    b.HasOne("GalaxItApi.Models.Bubble", "Bubble")
                        .WithMany("Tables")
                        .HasForeignKey("BubbleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GalaxItApi.Models.User", b =>
                {
                    b.HasOne("GalaxItApi.Models.Seat", "Seat")
                        .WithMany("Users")
                        .HasForeignKey("SeatId");
                });
#pragma warning restore 612, 618
        }
    }
}

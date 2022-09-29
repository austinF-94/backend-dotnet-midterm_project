﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using midterm_project.Migrations;

#nullable disable

namespace midterm_project.Migrations
{
    [DbContext(typeof(DragonsDbContext))]
    [Migration("20220929221150_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("midterm_project.Models.Dragons", b =>
                {
                    b.Property<int>("DragonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dragonDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("dragonDetails")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("dragonImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("dragonName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DragonId");

                    b.ToTable("Dragons");
                });
#pragma warning restore 612, 618
        }
    }
}

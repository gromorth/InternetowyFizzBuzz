﻿// <auto-generated />
using System;
using InternetowyFizzBuzz.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InternetowyFizzBuzz.Migrations
{
    [DbContext(typeof(FizzContex))]
    [Migration("20210413171554_InitSchema")]
    partial class InitSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternetowyFizzBuzz.Models.Container", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Container");
                });

            modelBuilder.Entity("InternetowyFizzBuzz.Models.FizzBuzz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContainerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numerek")
                        .HasColumnType("int");

                    b.Property<string>("Odpowiedz")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContainerId");

                    b.ToTable("FizzBuzz");
                });

            modelBuilder.Entity("InternetowyFizzBuzz.Models.FizzBuzz", b =>
                {
                    b.HasOne("InternetowyFizzBuzz.Models.Container", null)
                        .WithMany("FizzBuzzes")
                        .HasForeignKey("ContainerId");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using CSharpBank.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharpBank.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240411163423_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CSharpBank.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("CSharpBank.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("CSharpBank.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("CSharpBank.Models.Account", b =>
                {
                    b.HasOne("CSharpBank.Models.Customer", "Customer")
                        .WithMany("Accounts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CSharpBank.Models.Transaction", b =>
                {
                    b.HasOne("CSharpBank.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CSharpBank.Models.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("CSharpBank.Models.Customer", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
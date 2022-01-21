﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingCart.Repository.DBContext;

namespace ShoppingCart.Repository.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20220121095539_AddPayedAndCloseColumns")]
    partial class AddPayedAndCloseColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoppingCart.Repository.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BasketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ShoppingCart.Repository.Entities.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Close")
                        .HasColumnType("bit");

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Payed")
                        .HasColumnType("bit");

                    b.Property<bool>("PaysVAT")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("ShoppingCart.Repository.Entities.Article", b =>
                {
                    b.HasOne("ShoppingCart.Repository.Entities.Basket", "Basket")
                        .WithMany("Articles")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

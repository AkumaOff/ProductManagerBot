﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductManagerBot.Data;

#nullable disable

namespace ProductManagerBot.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231125195944_add_product")]
    partial class add_product
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("ProductManagerBot.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.FavoriteProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteProducts");
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.Manufacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Manufactures");
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Barcode")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Calories")
                        .HasColumnType("REAL");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfManufacture")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfUse")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ManufactureId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductContent")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ManufactureId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<long>("TgId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.FavoriteProduct", b =>
                {
                    b.HasOne("ProductManagerBot.Data.Entities.User", null)
                        .WithMany("FavoriteProducts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.Product", b =>
                {
                    b.HasOne("ProductManagerBot.Data.Entities.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductManagerBot.Data.Entities.Manufacture", "Manufacture")
                        .WithMany("Products")
                        .HasForeignKey("ManufactureId");

                    b.HasOne("ProductManagerBot.Data.Entities.User", null)
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacture");
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.Manufacture", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ProductManagerBot.Data.Entities.User", b =>
                {
                    b.Navigation("FavoriteProducts");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

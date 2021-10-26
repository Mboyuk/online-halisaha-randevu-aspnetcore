﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using halisahaapp.data.Concrete.EfCore;

namespace halisahaapp.data.Migrations
{
    [DbContext(typeof(HalisahaContext))]
    [Migration("20211025081602_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("halisahaapp.entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentContent")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("HalisahaId")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NickName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("point")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("HalisahaId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("halisahaapp.entity.Halisaha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Closing")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Openning")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Halisahas");
                });

            modelBuilder.Entity("halisahaapp.entity.HalisahaProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HalisahaId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HalisahaId");

                    b.HasIndex("PropertyId");

                    b.ToTable("HalisahaProperties");
                });

            modelBuilder.Entity("halisahaapp.entity.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HalisahaId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("HalisahaId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("halisahaapp.entity.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MessageContent")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("halisahaapp.entity.PreTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Date")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("HalisahaId")
                        .HasColumnType("int");

                    b.Property<string>("HalisahaName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Time")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("PreTransactions");
                });

            modelBuilder.Entity("halisahaapp.entity.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PropertyName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("halisahaapp.entity.Rezervation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HalisahaId")
                        .HasColumnType("int");

                    b.Property<string>("Saat")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tarih")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("HalisahaId");

                    b.ToTable("Rezervations");
                });

            modelBuilder.Entity("halisahaapp.entity.Comment", b =>
                {
                    b.HasOne("halisahaapp.entity.Halisaha", "Halisaha")
                        .WithMany("Comments")
                        .HasForeignKey("HalisahaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("halisahaapp.entity.HalisahaProperty", b =>
                {
                    b.HasOne("halisahaapp.entity.Halisaha", "Halisaha")
                        .WithMany("HalisahaProperties")
                        .HasForeignKey("HalisahaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("halisahaapp.entity.Property", "Property")
                        .WithMany("HalisahaProperties")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("halisahaapp.entity.Image", b =>
                {
                    b.HasOne("halisahaapp.entity.Halisaha", "Halisaha")
                        .WithMany("Images")
                        .HasForeignKey("HalisahaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("halisahaapp.entity.Rezervation", b =>
                {
                    b.HasOne("halisahaapp.entity.Halisaha", "Halisaha")
                        .WithMany("Rezervations")
                        .HasForeignKey("HalisahaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

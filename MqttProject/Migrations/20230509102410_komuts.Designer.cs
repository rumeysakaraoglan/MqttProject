﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MqttProject.Data;

#nullable disable

namespace MqttProject.Migrations
{
    [DbContext(typeof(contactData))]
    [Migration("20230509102410_komuts")]
    partial class komuts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MqttProject.Models.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MqttProject.Models.Komut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BaglantiDenemeSayisi")
                        .HasColumnType("int");

                    b.Property<int>("CihazId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Durum")
                        .HasColumnType("int");

                    b.Property<int>("KomutKod")
                        .HasColumnType("int");

                    b.Property<string>("KomutParams")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Komuts");
                });

            modelBuilder.Entity("MqttProject.Models.ModemGorev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dakika")
                        .HasColumnType("int");

                    b.Property<int>("Gorevid")
                        .HasColumnType("int");

                    b.Property<int>("Gun")
                        .HasColumnType("int");

                    b.Property<int?>("Komutid")
                        .HasColumnType("int");

                    b.Property<string>("ModemSeriNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Param")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Periyot")
                        .HasColumnType("bigint");

                    b.Property<int>("Saat")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.Property<int?>("rc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Komutid")
                        .IsUnique()
                        .HasFilter("[Komutid] IS NOT NULL");

                    b.ToTable("ModemGorevs");
                });

            modelBuilder.Entity("MqttProject.Models.contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ServerAden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubscribeTopic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("MqttProject.Models.ModemGorev", b =>
                {
                    b.HasOne("MqttProject.Models.Komut", null)
                        .WithOne("ModemGorev")
                        .HasForeignKey("MqttProject.Models.ModemGorev", "Komutid");
                });

            modelBuilder.Entity("MqttProject.Models.Komut", b =>
                {
                    b.Navigation("ModemGorev")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

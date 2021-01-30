﻿// <auto-generated />
using System;
using Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Streaminator_API.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20210130191454_Show")]
    partial class Show
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Models.Database.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<int>("REL_Video")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("Models.Database.WatchStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Location")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Saved")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("VideoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VideoId");

                    b.ToTable("WatchStatuses");
                });

            modelBuilder.Entity("Models.Database.WatchStatus", b =>
                {
                    b.HasOne("Models.Database.Video", "Video")
                        .WithMany()
                        .HasForeignKey("VideoId");

                    b.Navigation("Video");
                });
#pragma warning restore 612, 618
        }
    }
}

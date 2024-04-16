﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SasJobManager.Api.AclsManager.Domain;

#nullable disable

namespace SasJobManager.Api.AclsManager.Migrations
{
    [DbContext(typeof(SasLogContext))]
    partial class SasLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SasJobManager.Api.AclsManager.Model.SasLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LogFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SasLogs");
                });

            modelBuilder.Entity("SasJobManager.Api.AclsManager.Model.SasLogHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("SasLogId")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SasLogId");

                    b.ToTable("SasLogsHistory");
                });

            modelBuilder.Entity("SasJobManager.Api.AclsManager.Model.SasLogHistory", b =>
                {
                    b.HasOne("SasJobManager.Api.AclsManager.Model.SasLog", "SasLog")
                        .WithMany("History")
                        .HasForeignKey("SasLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SasLog");
                });

            modelBuilder.Entity("SasJobManager.Api.AclsManager.Model.SasLog", b =>
                {
                    b.Navigation("History");
                });
#pragma warning restore 612, 618
        }
    }
}

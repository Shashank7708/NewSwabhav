﻿// <auto-generated />
using System;
using ContactAndAddressApp_data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactAndAddressApp_data.Migrations
{
    [DbContext(typeof(ContactDbContext))]
    partial class ContactDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactAddressCore.Model.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ContactAddressCore.Model.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Mobileno")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("ContactAddressCore.Model.Tenent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TenentStrength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tenent");
                });

            modelBuilder.Entity("ContactAddressCore.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TenentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TenentId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ContactAddressCore.Model.Address", b =>
                {
                    b.HasOne("ContactAddressCore.Model.Contact", "Contact")
                        .WithMany("Address")
                        .HasForeignKey("ContactId");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("ContactAddressCore.Model.Contact", b =>
                {
                    b.HasOne("ContactAddressCore.Model.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ContactAddressCore.Model.User", b =>
                {
                    b.HasOne("ContactAddressCore.Model.Tenent", "Tenent")
                        .WithMany("Users")
                        .HasForeignKey("TenentId");

                    b.Navigation("Tenent");
                });

            modelBuilder.Entity("ContactAddressCore.Model.Contact", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("ContactAddressCore.Model.Tenent", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ContactAddressCore.Model.User", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}

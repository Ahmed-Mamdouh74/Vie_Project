﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vie_Cap.Server.Database;

namespace Vie_Cap.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211004065319_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vie_Cap.Shared.Activity", b =>
                {
                    b.Property<int>("A_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("A_Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Vie_Cap.Shared.Company", b =>
                {
                    b.Property<int>("Cop_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("A_Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("C_ID")
                        .HasColumnType("int");

                    b.Property<string>("Company_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Isvolved")
                        .HasColumnType("bit");

                    b.Property<string>("Legal_Bussiness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<string>("Web_Site")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cop_ID");

                    b.HasIndex("A_Id");

                    b.HasIndex("C_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Vie_Cap.Shared.Country", b =>
                {
                    b.Property<int>("C_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alpha2code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alpha3code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Sk_Country")
                        .HasColumnType("int");

                    b.HasKey("C_ID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Vie_Cap.Shared.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("C_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBrith")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JopTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("National_ID")
                        .HasColumnType("int");

                    b.Property<float>("OwnerShip")
                        .HasColumnType("real");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("User_ID");

                    b.HasIndex("C_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Vie_Cap.Shared.Company", b =>
                {
                    b.HasOne("Vie_Cap.Shared.Activity", "Activity")
                        .WithMany("companies")
                        .HasForeignKey("A_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vie_Cap.Shared.Country", "Country")
                        .WithMany("companies")
                        .HasForeignKey("C_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vie_Cap.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Country");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Vie_Cap.Shared.User", b =>
                {
                    b.HasOne("Vie_Cap.Shared.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("C_ID");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Vie_Cap.Shared.Activity", b =>
                {
                    b.Navigation("companies");
                });

            modelBuilder.Entity("Vie_Cap.Shared.Country", b =>
                {
                    b.Navigation("companies");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

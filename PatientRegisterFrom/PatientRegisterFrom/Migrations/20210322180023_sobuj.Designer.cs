// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientRegisterFrom.Models;

namespace PatientRegisterFrom.Migrations
{
    [DbContext(typeof(RegisterDbContext))]
    [Migration("20210322180023_sobuj")]
    partial class sobuj
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PatientRegisterFrom.Models.Register", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("age")
                        .IsRequired();

                    b.Property<string>("bloodGroup")
                        .IsRequired();

                    b.Property<string>("bodyWeight");

                    b.Property<string>("disability")
                        .IsRequired();

                    b.Property<string>("firstName")
                        .IsRequired();

                    b.Property<string>("homeAddress")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("kinAddress")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("kinName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("kinPhoneNo")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("maritalStatus")
                        .IsRequired();

                    b.Property<string>("sex")
                        .IsRequired();

                    b.Property<string>("surName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime>("visitDate")
                        .HasColumnType("date");

                    b.Property<string>("workAddress")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.ToTable("Registers");
                });
#pragma warning restore 612, 618
        }
    }
}

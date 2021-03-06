// <auto-generated />
using System;
using ConsumerDebit.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ConsumerDebit.Migrations
{
    [DbContext(typeof(ConsumerDebitDbContext))]
    [Migration("20220213172922_TrafficMigration")]
    partial class TrafficMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ConsumerDebit.Model.Traffic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Claims")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Document")
                        .HasColumnType("text");

                    b.Property<int>("Owes")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Traffics");
                });

            modelBuilder.Entity("ConsumerDebit.Model.User", b =>
                {
                    b.Property<string>("IDUser")
                        .HasColumnType("text");

                    b.Property<string>("Owner")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("IDUser");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            IDUser = "S00001",
                            Owner = "Novakovic Petar",
                            Password = "317D"
                        },
                        new
                        {
                            IDUser = "S00002",
                            Owner = "Miloševic Dragan",
                            Password = "EFFC"
                        },
                        new
                        {
                            IDUser = "S00003",
                            Owner = "Bardak Željko",
                            Password = "5110"
                        });
                });

            modelBuilder.Entity("ConsumerDebit.Model.Traffic", b =>
                {
                    b.HasOne("ConsumerDebit.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}

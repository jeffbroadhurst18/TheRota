using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TheRota.Models;

namespace TheRota.Migrations
{
    [DbContext(typeof(RotaContext))]
    [Migration("20170715202203_Init2")]
    partial class Init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheRota.Models.Fixture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FixtureDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Fixtures");
                });

            modelBuilder.Entity("TheRota.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FirstName");

                    b.Property<string>("IdNumber");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TheRota.Models.PersonRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonId");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonRoles");
                });

            modelBuilder.Entity("TheRota.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("TheRota.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TheRota.Models.Rota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FixtureId");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("FixtureId");

                    b.HasIndex("PersonId");

                    b.HasIndex("RoleId");

                    b.ToTable("Rotas");
                });

            modelBuilder.Entity("TheRota.Models.PersonRole", b =>
                {
                    b.HasOne("TheRota.Models.Person")
                        .WithMany("PersonRoles")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheRota.Models.Rota", b =>
                {
                    b.HasOne("TheRota.Models.Fixture", "Fixture")
                        .WithMany()
                        .HasForeignKey("FixtureId");

                    b.HasOne("TheRota.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("TheRota.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });
        }
    }
}

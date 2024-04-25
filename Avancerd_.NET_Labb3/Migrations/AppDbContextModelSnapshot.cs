﻿// <auto-generated />
using Avancerd_.NET_Labb3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Avancerd_.NET_Labb3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb3_Models_.Hobby", b =>
                {
                    b.Property<int>("HobbyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HobbyID"));

                    b.Property<string>("HobbyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("HobbyID");

                    b.HasIndex("PersonID");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            HobbyID = 1,
                            HobbyDescription = "Skiing down the mountains... ",
                            HobbyTitle = "Skiing",
                            PersonID = 3
                        },
                        new
                        {
                            HobbyID = 2,
                            HobbyDescription = "Knitting shirts, mittens and hats ",
                            HobbyTitle = "Knitting",
                            PersonID = 3
                        },
                        new
                        {
                            HobbyID = 3,
                            HobbyDescription = "Surfing the waves like a real proffesional ",
                            HobbyTitle = "Surfing",
                            PersonID = 2
                        },
                        new
                        {
                            HobbyID = 4,
                            HobbyDescription = "Hacking computers since 1996 ",
                            HobbyTitle = "Hacking",
                            PersonID = 2
                        },
                        new
                        {
                            HobbyID = 5,
                            HobbyDescription = "Swimming like Phelps since 1996",
                            HobbyTitle = "Swimming",
                            PersonID = 1
                        },
                        new
                        {
                            HobbyID = 6,
                            HobbyDescription = "Throwing larger balls at smaller balls, really fun",
                            HobbyTitle = "Boule",
                            PersonID = 1
                        },
                        new
                        {
                            HobbyID = 7,
                            HobbyDescription = "Gaming all kinds of games, FPS, MMORPG and RTS games",
                            HobbyTitle = "Gaming",
                            PersonID = 1
                        },
                        new
                        {
                            HobbyID = 8,
                            HobbyDescription = "Skating and punching people since 1996",
                            HobbyTitle = "Hockey",
                            PersonID = 2
                        });
                });

            modelBuilder.Entity("Labb3_Models_.Link", b =>
                {
                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LinkID"));

                    b.Property<int>("HobbyID")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkID");

                    b.HasIndex("HobbyID");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            LinkID = 1,
                            HobbyID = 1,
                            URL = "https://en.wikipedia.org/wiki/Skiing"
                        },
                        new
                        {
                            LinkID = 2,
                            HobbyID = 1,
                            URL = "https://visitsweden.com/what-to-do/nature-outdoors/winter-activities/skiing-sweden/"
                        },
                        new
                        {
                            LinkID = 3,
                            HobbyID = 2,
                            URL = "https://en.wikipedia.org/wiki/Knitting"
                        },
                        new
                        {
                            LinkID = 4,
                            HobbyID = 2,
                            URL = "https://sheepandstitch.com/how-to-knit/"
                        },
                        new
                        {
                            LinkID = 5,
                            HobbyID = 3,
                            URL = "https://sv.wikipedia.org/wiki/Surfing"
                        },
                        new
                        {
                            LinkID = 6,
                            HobbyID = 3,
                            URL = "https://www.kilroy.se/reseblogg/8-fantastiska-surfdestinationer-over-hela-varlden"
                        },
                        new
                        {
                            LinkID = 7,
                            HobbyID = 4,
                            URL = "https://www.ibm.com/topics/cyber-hacking"
                        },
                        new
                        {
                            LinkID = 8,
                            HobbyID = 5,
                            URL = "https://en.wikipedia.org/wiki/Swimming_(sport)"
                        },
                        new
                        {
                            LinkID = 9,
                            HobbyID = 5,
                            URL = "https://www.britannica.com/sports/swimming-sport"
                        },
                        new
                        {
                            LinkID = 10,
                            HobbyID = 6,
                            URL = "https://sv.wikipedia.org/wiki/Boule"
                        },
                        new
                        {
                            LinkID = 11,
                            HobbyID = 7,
                            URL = "https://sv.wikipedia.org/wiki/Gamer"
                        },
                        new
                        {
                            LinkID = 12,
                            HobbyID = 8,
                            URL = "https://www.swehockey.se"
                        },
                        new
                        {
                            LinkID = 13,
                            HobbyID = 8,
                            URL = "https://sv.wikipedia.org/wiki/Ishockey"
                        });
                });

            modelBuilder.Entity("Labb3_Models_.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonID"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonID = 1,
                            FirstName = "Ludwig",
                            LastName = "Qlok",
                            PhoneNumber = "070123456"
                        },
                        new
                        {
                            PersonID = 2,
                            FirstName = "Anas",
                            LastName = "Qlok",
                            PhoneNumber = "070765431"
                        },
                        new
                        {
                            PersonID = 3,
                            FirstName = "Reidar",
                            LastName = "Qlok",
                            PhoneNumber = "070098765"
                        });
                });

            modelBuilder.Entity("Labb3_Models_.Hobby", b =>
                {
                    b.HasOne("Labb3_Models_.Person", "Person")
                        .WithMany("Hobbies")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Labb3_Models_.Link", b =>
                {
                    b.HasOne("Labb3_Models_.Hobby", "Hobby")
                        .WithMany("Links")
                        .HasForeignKey("HobbyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hobby");
                });

            modelBuilder.Entity("Labb3_Models_.Hobby", b =>
                {
                    b.Navigation("Links");
                });

            modelBuilder.Entity("Labb3_Models_.Person", b =>
                {
                    b.Navigation("Hobbies");
                });
#pragma warning restore 612, 618
        }
    }
}

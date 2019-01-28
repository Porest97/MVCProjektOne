﻿// <auto-generated />
using System;
using MVCOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCOne.Migrations
{
    [DbContext(typeof(MVCOneContext))]
    [Migration("20190128222702_Match")]
    partial class Match
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCOne.Models.Arena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvailabilityHoursMoFre");

                    b.Property<string>("AvailabilityHoursWeekEnds");

                    b.Property<string>("City");

                    b.Property<string>("County");

                    b.Property<string>("FoodCourt");

                    b.Property<string>("Name");

                    b.Property<string>("NameNumberOfKonferanses");

                    b.Property<string>("ParkingSpace");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZIPCode");

                    b.HasKey("Id");

                    b.ToTable("Arena");
                });

            modelBuilder.Entity("MVCOne.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArenaId");

                    b.Property<DateTime>("MatchDate");

                    b.Property<int?>("Referee1Id");

                    b.Property<int?>("Referee2Id");

                    b.Property<int?>("Referee3Id");

                    b.Property<int?>("Referee4Id");

                    b.Property<string>("Score1");

                    b.Property<string>("Score2");

                    b.Property<int?>("SeriesId");

                    b.Property<int?>("Team1Id");

                    b.Property<int?>("Team2Id");

                    b.HasKey("Id");

                    b.HasIndex("ArenaId");

                    b.HasIndex("Referee1Id");

                    b.HasIndex("Referee2Id");

                    b.HasIndex("Referee3Id");

                    b.HasIndex("Referee4Id");

                    b.HasIndex("SeriesId");

                    b.HasIndex("Team1Id");

                    b.HasIndex("Team2Id");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("MVCOne.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Association");

                    b.Property<string>("Category");

                    b.Property<string>("City");

                    b.Property<string>("CoName");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<string>("Distrikt");

                    b.Property<string>("EMail");

                    b.Property<string>("ExaminationLevel");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Nationality");

                    b.Property<long>("Phone1");

                    b.Property<long>("Phone2");

                    b.Property<string>("RefCategoryType");

                    b.Property<string>("RefNumber");

                    b.Property<string>("RefType");

                    b.Property<long>("Ssn");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZIPCode");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("MVCOne.Models.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RefIDId");

                    b.HasKey("Id");

                    b.HasIndex("RefIDId");

                    b.ToTable("Referee");
                });

            modelBuilder.Entity("MVCOne.Models.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discription");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("MVCOne.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HomeArena");

                    b.Property<string>("Name");

                    b.Property<string>("TeamAssistingCoach1");

                    b.Property<string>("TeamAssistingCoach2");

                    b.Property<string>("TeamCashier");

                    b.Property<string>("TeamHeadCoach");

                    b.Property<string>("TeamStaff1");

                    b.Property<string>("TeamStaff2");

                    b.Property<string>("TeamStaff3");

                    b.Property<string>("TeamType");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("MVCOne.Models.Match", b =>
                {
                    b.HasOne("MVCOne.Models.Arena", "Arena")
                        .WithMany()
                        .HasForeignKey("ArenaId");

                    b.HasOne("MVCOne.Models.Referee", "Referee1")
                        .WithMany()
                        .HasForeignKey("Referee1Id");

                    b.HasOne("MVCOne.Models.Referee", "Referee2")
                        .WithMany()
                        .HasForeignKey("Referee2Id");

                    b.HasOne("MVCOne.Models.Referee", "Referee3")
                        .WithMany()
                        .HasForeignKey("Referee3Id");

                    b.HasOne("MVCOne.Models.Referee", "Referee4")
                        .WithMany()
                        .HasForeignKey("Referee4Id");

                    b.HasOne("MVCOne.Models.Series", "Series")
                        .WithMany()
                        .HasForeignKey("SeriesId");

                    b.HasOne("MVCOne.Models.Team", "Team1")
                        .WithMany()
                        .HasForeignKey("Team1Id");

                    b.HasOne("MVCOne.Models.Team", "Team2")
                        .WithMany()
                        .HasForeignKey("Team2Id");
                });

            modelBuilder.Entity("MVCOne.Models.Referee", b =>
                {
                    b.HasOne("MVCOne.Models.Person", "RefID")
                        .WithMany()
                        .HasForeignKey("RefIDId");
                });
#pragma warning restore 612, 618
        }
    }
}

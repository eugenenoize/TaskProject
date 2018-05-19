﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TaskProject.Models;

namespace TaskProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180518112429_v.0.0.3")]
    partial class v003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TaskProject.Models.Aligment", b =>
                {
                    b.Property<int>("AligmentId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("AligmentId");

                    b.ToTable("Aligments");
                });

            modelBuilder.Entity("TaskProject.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("Age");

                    b.Property<int?>("AligmentId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<long>("CurrentExp");

                    b.Property<int>("CurrentGold");

                    b.Property<int>("CurrentHealth");

                    b.Property<int>("CurrentLevel");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<float>("Growth");

                    b.Property<float>("IMT");

                    b.Property<string>("Information");

                    b.Property<bool>("IsDead");

                    b.Property<bool>("IsSetValue");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<long>("MaxExp");

                    b.Property<int>("MaxHealth");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Sex");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<float>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("AligmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TaskProject.Models.Atribute", b =>
                {
                    b.Property<int>("AtributeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentExp");

                    b.Property<string>("Description");

                    b.Property<int>("Lvl");

                    b.Property<int>("MaxExp");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("AtributeId");

                    b.HasIndex("UserId");

                    b.ToTable("Atributes");
                });

            modelBuilder.Entity("TaskProject.Models.Complication", b =>
                {
                    b.Property<int>("ComplicationId");

                    b.Property<int>("Damage");

                    b.Property<int>("Exp");

                    b.Property<int>("Gold");

                    b.Property<string>("Name");

                    b.HasKey("ComplicationId");

                    b.ToTable("Complications");
                });

            modelBuilder.Entity("TaskProject.Models.Goal", b =>
                {
                    b.Property<int>("GoalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ComplicationId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("GoalEnd");

                    b.Property<DateTime>("GoalStart");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("RepeatId");

                    b.Property<int?>("SkillId");

                    b.Property<string>("UserId");

                    b.HasKey("GoalId");

                    b.HasIndex("ComplicationId");

                    b.HasIndex("RepeatId");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("TaskProject.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<string>("DateCreate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Theme");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("TaskProject.Models.Rating", b =>
                {
                    b.Property<int>("RatingId");

                    b.Property<string>("Name");

                    b.HasKey("RatingId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("TaskProject.Models.Repeat", b =>
                {
                    b.Property<int>("RepeatId");

                    b.Property<string>("Name");

                    b.HasKey("RepeatId");

                    b.ToTable("Repeats");
                });

            modelBuilder.Entity("TaskProject.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AtributeId");

                    b.Property<int>("CurrentExp");

                    b.Property<int>("Lvl");

                    b.Property<int>("MaxExp");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("RatingId");

                    b.Property<string>("UserId");

                    b.HasKey("SkillId");

                    b.HasIndex("AtributeId");

                    b.HasIndex("RatingId");

                    b.HasIndex("UserId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskProject.Models.ApplicationUser", b =>
                {
                    b.HasOne("TaskProject.Models.Aligment", "Aligment")
                        .WithMany()
                        .HasForeignKey("AligmentId");
                });

            modelBuilder.Entity("TaskProject.Models.Atribute", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("Atributes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TaskProject.Models.Goal", b =>
                {
                    b.HasOne("TaskProject.Models.Complication", "Complication")
                        .WithMany()
                        .HasForeignKey("ComplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.Repeat", "Repeat")
                        .WithMany()
                        .HasForeignKey("RepeatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.Skill", "Skill")
                        .WithMany("Goals")
                        .HasForeignKey("SkillId");

                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("Goals")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TaskProject.Models.Skill", b =>
                {
                    b.HasOne("TaskProject.Models.Atribute", "Atribute")
                        .WithMany("Skills")
                        .HasForeignKey("AtributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}

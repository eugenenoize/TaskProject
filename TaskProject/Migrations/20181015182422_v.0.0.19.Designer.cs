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
    [Migration("20181015182422_v.0.0.19")]
    partial class v0019
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

            modelBuilder.Entity("TaskProject.Models.AchievementModels.Achievement", b =>
                {
                    b.Property<int>("AchievementId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AchievementType");

                    b.Property<string>("Description");

                    b.Property<string>("LinkImg");

                    b.Property<string>("Name");

                    b.HasKey("AchievementId");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("TaskProject.Models.AchievementModels.UserAchievement", b =>
                {
                    b.Property<int>("UserAchievementId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AchievementId");

                    b.Property<bool>("IsOpen");

                    b.Property<DateTime?>("SetDate");

                    b.Property<string>("UserId");

                    b.HasKey("UserAchievementId");

                    b.HasIndex("AchievementId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAchievements");
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

                    b.Property<int?>("AligmentId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<long>("CurrentExp");

                    b.Property<int>("CurrentGold");

                    b.Property<int>("CurrentLevel");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int?>("HealthId");

                    b.Property<bool>("IsSetDefaultValues");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<long>("MaxExp");

                    b.Property<string>("NickName");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

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

            modelBuilder.Entity("TaskProject.Models.GoalModels.Catalog", b =>
                {
                    b.Property<int>("CatalogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("UserId");

                    b.HasKey("CatalogId");

                    b.HasIndex("UserId");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("TaskProject.Models.GoalModels.Complication", b =>
                {
                    b.Property<int>("ComplicationId");

                    b.Property<int>("Damage");

                    b.Property<int>("Exp");

                    b.Property<int>("Gold");

                    b.Property<string>("Name");

                    b.HasKey("ComplicationId");

                    b.ToTable("Complications");
                });

            modelBuilder.Entity("TaskProject.Models.GoalModels.Goal", b =>
                {
                    b.Property<int>("GoalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CatalogId");

                    b.Property<int>("ComplicationId");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<int>("FinishCount");

                    b.Property<DateTime?>("GoalEnd");

                    b.Property<DateTime?>("GoalStart")
                        .IsRequired();

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PassCount");

                    b.Property<int>("RepeatId");

                    b.Property<int>("SeriesCount");

                    b.Property<int?>("SkillId");

                    b.Property<string>("UserId");

                    b.HasKey("GoalId");

                    b.HasIndex("CatalogId");

                    b.HasIndex("ComplicationId");

                    b.HasIndex("RepeatId");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("TaskProject.Models.GoalModels.Repeat", b =>
                {
                    b.Property<int>("RepeatId");

                    b.Property<string>("Name");

                    b.HasKey("RepeatId");

                    b.ToTable("Repeats");
                });

            modelBuilder.Entity("TaskProject.Models.Health", b =>
                {
                    b.Property<int>("HealthId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateBirth");

                    b.Property<DateTime?>("DateDeath");

                    b.Property<bool>("IsDead");

                    b.Property<bool>("IsSetValue");

                    b.Property<string>("Sex");

                    b.Property<string>("UserId");

                    b.HasKey("HealthId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Healths");
                });

            modelBuilder.Entity("TaskProject.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("HobbyId");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("TaskProject.Models.LogsModels.LogAccess", b =>
                {
                    b.Property<int>("LogAccessId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Log");

                    b.Property<string>("UserAgent");

                    b.Property<string>("UserName");

                    b.HasKey("LogAccessId");

                    b.ToTable("LogAccess");
                });

            modelBuilder.Entity("TaskProject.Models.LogsModels.LogEvent", b =>
                {
                    b.Property<int>("LogEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("EventId");

                    b.Property<string>("LogLevel");

                    b.Property<string>("Message");

                    b.HasKey("LogEventId");

                    b.ToTable("LogEvents");
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

            modelBuilder.Entity("TaskProject.Models.Mood", b =>
                {
                    b.Property<int>("MoodId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LinkImg");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("MoodId");

                    b.ToTable("Moods");
                });

            modelBuilder.Entity("TaskProject.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired();

                    b.Property<string>("Text");

                    b.Property<string>("Theme");

                    b.Property<string>("UserId");

                    b.HasKey("NoteId");

                    b.HasIndex("UserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("TaskProject.Models.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreate");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("NotificationID");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TaskProject.Models.Rating", b =>
                {
                    b.Property<int>("RatingId");

                    b.Property<string>("Name");

                    b.HasKey("RatingId");

                    b.ToTable("Ratings");
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

            modelBuilder.Entity("TaskProject.Models.UserGrowth", b =>
                {
                    b.Property<int>("UserGrowthId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("HealthId");

                    b.Property<float>("Value");

                    b.HasKey("UserGrowthId");

                    b.HasIndex("HealthId");

                    b.ToTable("UserGrowth");
                });

            modelBuilder.Entity("TaskProject.Models.UserMood", b =>
                {
                    b.Property<int>("UserMoodId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("Date");

                    b.Property<int>("MoodId");

                    b.Property<string>("UserId");

                    b.HasKey("UserMoodId");

                    b.HasIndex("MoodId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMoods");
                });

            modelBuilder.Entity("TaskProject.Models.UserReward", b =>
                {
                    b.Property<int>("UserRewardId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Cost");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("UserRewardId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRewards");
                });

            modelBuilder.Entity("TaskProject.Models.UserWeight", b =>
                {
                    b.Property<int>("UserWeightId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("HealthId");

                    b.Property<float>("Value");

                    b.HasKey("UserWeightId");

                    b.HasIndex("HealthId");

                    b.ToTable("UserWeight");
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

            modelBuilder.Entity("TaskProject.Models.AchievementModels.UserAchievement", b =>
                {
                    b.HasOne("TaskProject.Models.AchievementModels.Achievement", "Achievement")
                        .WithMany()
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("UserAchievements")
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
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskProject.Models.GoalModels.Catalog", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("Catalogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("TaskProject.Models.GoalModels.Goal", b =>
                {
                    b.HasOne("TaskProject.Models.GoalModels.Catalog", "Catalog")
                        .WithMany("Goals")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("TaskProject.Models.GoalModels.Complication", "Complication")
                        .WithMany()
                        .HasForeignKey("ComplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.GoalModels.Repeat", "Repeat")
                        .WithMany()
                        .HasForeignKey("RepeatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.Skill", "Skill")
                        .WithMany("Goals")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("Goals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskProject.Models.Health", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithOne("Health")
                        .HasForeignKey("TaskProject.Models.Health", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskProject.Models.Note", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("Notes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskProject.Models.Notification", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("TaskProject.Models.UserGrowth", b =>
                {
                    b.HasOne("TaskProject.Models.Health", "Health")
                        .WithMany("UserListGrowth")
                        .HasForeignKey("HealthId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskProject.Models.UserMood", b =>
                {
                    b.HasOne("TaskProject.Models.Mood", "Mood")
                        .WithMany("UserMoods")
                        .HasForeignKey("MoodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("UserMoods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskProject.Models.UserReward", b =>
                {
                    b.HasOne("TaskProject.Models.ApplicationUser", "User")
                        .WithMany("UserRewards")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TaskProject.Models.UserWeight", b =>
                {
                    b.HasOne("TaskProject.Models.Health", "Health")
                        .WithMany("UserListWeight")
                        .HasForeignKey("HealthId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

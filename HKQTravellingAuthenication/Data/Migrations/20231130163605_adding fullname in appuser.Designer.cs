﻿// <auto-generated />
using System;
using HKQTravellingAuthenication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HKQTravellingAuthenication.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231130163605_adding fullname in appuser")]
    partial class addingfullnameinappuser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Blog.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.HasIndex("Slug");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Contact.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Bookings", b =>
                {
                    b.Property<long>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("BOOKING_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BookingId"));

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BOOKING_DATE");

                    b.Property<int?>("NumAdults")
                        .HasColumnType("int")
                        .HasColumnName("NUM_ADULTS");

                    b.Property<int?>("NumKids")
                        .HasColumnType("int")
                        .HasColumnName("NUM_KIDS");

                    b.Property<int?>("NumToddlers")
                        .HasColumnType("int")
                        .HasColumnName("NUM_TODDLERS");

                    b.Property<double?>("PriceAdults")
                        .HasColumnType("float")
                        .HasColumnName("PRICE_ADULTS");

                    b.Property<double?>("PriceKids")
                        .HasColumnType("float")
                        .HasColumnName("PRICE_KIDS");

                    b.Property<double?>("PriceToddlers")
                        .HasColumnType("float")
                        .HasColumnName("PRICE_TODDLERS");

                    b.Property<long?>("TourId")
                        .HasColumnType("bigint")
                        .HasColumnName("TOUR_ID");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("USER_ID");

                    b.HasKey("BookingId");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Discounts", b =>
                {
                    b.Property<long>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("DIS_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DiscountId"));

                    b.Property<DateTime?>("DiscountDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DIS_DATE");

                    b.Property<string>("DiscountName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("DIS_NAME");

                    b.Property<double?>("DiscountPercentage")
                        .HasColumnType("float")
                        .HasColumnName("DIS_PER");

                    b.Property<int?>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.HasKey("DiscountId");

                    b.ToTable("discounts");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.EndLocations", b =>
                {
                    b.Property<long>("EndLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("END_LOCATION_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EndLocationId"));

                    b.Property<string>("EndLocationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("END_LOCATION_NAME");

                    b.HasKey("EndLocationId");

                    b.HasIndex("EndLocationName")
                        .IsUnique();

                    b.ToTable("endLocations");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Payments", b =>
                {
                    b.Property<long>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("PAYMENT_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PaymentId"));

                    b.Property<int?>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("AMOUNT");

                    b.Property<long?>("BookingId")
                        .HasColumnType("bigint")
                        .HasColumnName("BOOKING_ID");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("PAYMENT_DATE");

                    b.Property<double?>("TotalPrices")
                        .HasColumnType("float")
                        .HasColumnName("TOTAL_PRICE");

                    b.HasKey("PaymentId");

                    b.HasIndex("BookingId");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Rules", b =>
                {
                    b.Property<long>("TourId")
                        .HasColumnType("bigint");

                    b.Property<string>("CancelChange")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("CANCLE_CHANGE");

                    b.Property<string>("Note")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("NOTE");

                    b.Property<string>("PriceInclude")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("PRICE_INCLUDE");

                    b.Property<string>("PriceNotInclude")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("PRICE_NOT_INCLUDE");

                    b.Property<string>("Surcharge")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("SURCHARGE");

                    b.HasKey("TourId");

                    b.ToTable("rules");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.StartLocations", b =>
                {
                    b.Property<long>("StartLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("START_LOCATION_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StartLocationId"));

                    b.Property<string>("StartLocationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("START_LOCATION_NAME");

                    b.HasKey("StartLocationId");

                    b.HasIndex("StartLocationName")
                        .IsUnique();

                    b.ToTable("startLocations");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.TourDays", b =>
                {
                    b.Property<long>("TourDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("TOUR_DAY_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TourDayId"));

                    b.Property<int?>("DayNumber")
                        .HasColumnType("int")
                        .HasColumnName("DAY_NUMBER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DESTINATION");

                    b.Property<DateTime?>("TimeSchedule")
                        .HasColumnType("datetime2")
                        .HasColumnName("TIME_SCHEDULE");

                    b.Property<long?>("TourId")
                        .HasColumnType("bigint")
                        .HasColumnName("TOUR_ID");

                    b.HasKey("TourDayId");

                    b.HasIndex("TourId");

                    b.ToTable("tourDays");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.TourImages", b =>
                {
                    b.Property<long>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("IMAGE_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ImageId"));

                    b.Property<int?>("DayNumber")
                        .HasColumnType("int")
                        .HasColumnName("DAY_NUMBER");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMAGE_URL");

                    b.Property<long?>("TourId")
                        .HasColumnType("bigint")
                        .HasColumnName("TOUR_ID");

                    b.HasKey("ImageId");

                    b.HasIndex("TourId");

                    b.ToTable("tourImages");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Tours", b =>
                {
                    b.Property<long>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("TOUR_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TourId"));

                    b.Property<DateTime?>("CreationDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATION_DATE");

                    b.Property<long?>("DiscountId")
                        .HasColumnType("bigint")
                        .HasColumnName("DIS_ID");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("END_DATE");

                    b.Property<long?>("EndLocationId")
                        .HasColumnType("bigint")
                        .HasColumnName("END_LOCATION_ID");

                    b.Property<int?>("Price")
                        .HasColumnType("int")
                        .HasColumnName("PRICE");

                    b.Property<int?>("Remaining")
                        .HasColumnType("int")
                        .HasColumnName("REMAINING");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("START_DATE");

                    b.Property<long?>("StartLocationId")
                        .HasColumnType("bigint")
                        .HasColumnName("START_LOCATION_ID");

                    b.Property<int?>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<string>("TourName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("TOUR_NAME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("TourId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("EndLocationId");

                    b.HasIndex("StartLocationId");

                    b.ToTable("tours");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar");

                    b.Property<string>("HomeAdress")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar");

                    b.ToTable("Users");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Blog.Category", b =>
                {
                    b.HasOne("HKQTravellingAuthenication.Models.Blog.Category", "ParentCategory")
                        .WithMany("CategoryChildren")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Bookings", b =>
                {
                    b.HasOne("HKQTravellingAuthenication.Models.Tour.Tours", "tours")
                        .WithMany()
                        .HasForeignKey("TourId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("tours");

                    b.Navigation("users");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Payments", b =>
                {
                    b.HasOne("HKQTravellingAuthenication.Models.Tour.Bookings", "bookings")
                        .WithMany()
                        .HasForeignKey("BookingId");

                    b.Navigation("bookings");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Rules", b =>
                {
                    b.HasOne("HKQTravellingAuthenication.Models.Tour.Tours", "tours")
                        .WithOne()
                        .HasForeignKey("HKQTravellingAuthenication.Models.Tour.Rules", "TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tours");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.TourDays", b =>
                {
                    b.HasOne("HKQTravellingAuthenication.Models.Tour.Tours", "tours")
                        .WithMany()
                        .HasForeignKey("TourId");

                    b.Navigation("tours");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.TourImages", b =>
                {
                    b.HasOne("HKQTravellingAuthenication.Models.Tour.Tours", "tours")
                        .WithMany()
                        .HasForeignKey("TourId");

                    b.Navigation("tours");
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Tour.Tours", b =>
                {
                    b.HasOne("HKQTravellingAuthenication.Models.Tour.Discounts", "discounts")
                        .WithMany()
                        .HasForeignKey("DiscountId");

                    b.HasOne("HKQTravellingAuthenication.Models.Tour.EndLocations", "endLocations")
                        .WithMany()
                        .HasForeignKey("EndLocationId");

                    b.HasOne("HKQTravellingAuthenication.Models.Tour.StartLocations", "startLocations")
                        .WithMany()
                        .HasForeignKey("StartLocationId");

                    b.Navigation("discounts");

                    b.Navigation("endLocations");

                    b.Navigation("startLocations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HKQTravellingAuthenication.Models.Blog.Category", b =>
                {
                    b.Navigation("CategoryChildren");
                });
#pragma warning restore 612, 618
        }
    }
}

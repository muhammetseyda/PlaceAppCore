﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaceApp.Data;

#nullable disable

namespace PlaceApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231106191058_AddComent")]
    partial class AddComent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlaceApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PlaceApp.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("PlaceApp.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("PlaceApp.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IsLiked")
                        .HasColumnType("int");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("LikeTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UnLikeTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("PlaceApp.Models.PlaceLists", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlaceLists");
                });

            modelBuilder.Entity("PlaceApp.Models.Places", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("AtmosphereRating")
                        .HasColumnType("real");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("FoodRating")
                        .HasColumnType("real");

                    b.Property<string>("InstaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapsLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceListsId")
                        .HasColumnType("int");

                    b.Property<bool>("RetryWent")
                        .HasColumnType("bit");

                    b.Property<float>("ServiceRating")
                        .HasColumnType("real");

                    b.Property<int?>("SharePlaceListId")
                        .HasColumnType("int");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSiteLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Went")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PlaceListsId");

                    b.HasIndex("SharePlaceListId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("PlaceApp.Models.SharePlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("AtmosphereRating")
                        .HasColumnType("real");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("FoodRating")
                        .HasColumnType("real");

                    b.Property<string>("InstaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapsLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.Property<float>("ServiceRating")
                        .HasColumnType("real");

                    b.Property<int?>("SharePlaceListId")
                        .HasColumnType("int");

                    b.Property<int>("Show")
                        .HasColumnType("int");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSiteLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SharePlaceListId");

                    b.ToTable("SharePlace");
                });

            modelBuilder.Entity("PlaceApp.Models.SharePlaceList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<string>("ListDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<string>("ListName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SharePlaceList");
                });

            modelBuilder.Entity("PlaceApp.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("TownCode")
                        .HasColumnType("int");

                    b.Property<string>("TownName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Town");
                });

            modelBuilder.Entity("PlaceApp.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PlaceApp.Models.Places", b =>
                {
                    b.HasOne("PlaceApp.Models.PlaceLists", null)
                        .WithMany("Places")
                        .HasForeignKey("PlaceListsId");

                    b.HasOne("PlaceApp.Models.SharePlaceList", null)
                        .WithMany("Places")
                        .HasForeignKey("SharePlaceListId");
                });

            modelBuilder.Entity("PlaceApp.Models.SharePlace", b =>
                {
                    b.HasOne("PlaceApp.Models.SharePlaceList", null)
                        .WithMany("SharePlace")
                        .HasForeignKey("SharePlaceListId");
                });

            modelBuilder.Entity("PlaceApp.Models.PlaceLists", b =>
                {
                    b.Navigation("Places");
                });

            modelBuilder.Entity("PlaceApp.Models.SharePlaceList", b =>
                {
                    b.Navigation("Places");

                    b.Navigation("SharePlace");
                });
#pragma warning restore 612, 618
        }
    }
}

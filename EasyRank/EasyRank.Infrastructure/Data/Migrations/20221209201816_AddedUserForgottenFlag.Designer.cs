﻿// <auto-generated />
using System;
using EasyRank.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyRank.Infrastructure.Data.Migrations
{
    [DbContext(typeof(EasyRankDbContext))]
    [Migration("20221209201816_AddedUserForgottenFlag")]
    partial class AddedUserForgottenFlag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasComment("Gets or sets the first name for a user.");

                    b.Property<bool>("IsForgotten")
                        .HasColumnType("bit")
                        .HasComment("Gets or sets a value indicating whether a user has been forgotten (deleted).");

                    b.Property<string>("LastName")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Gets or sets the last name for a user.");

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

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)")
                        .HasComment("Gets or sets the profile picture of the user.");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasComment("The 'EasyRankUser' model for the database.");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b54091aa-7e94-4378-881f-10b88a66ea22"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "10ae6bc8-f58b-40c3-912b-ec21e3fe9b3a",
                            Email = "guest@mail.com",
                            EmailConfirmed = true,
                            FirstName = "Guest",
                            IsForgotten = false,
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@MAIL.COM",
                            NormalizedUserName = "GUEST",
                            PasswordHash = "AQAAAAEAACcQAAAAELkAPVJKeX2fm79WAAYph3PLYUJWBuxyG3ZsHQ/txm0xhU+UUE79/4E6IFrOPiGk5w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d89768c5-8f8c-471f-a276-26e4a1b13d65",
                            TwoFactorEnabled = false,
                            UserName = "guest"
                        },
                        new
                        {
                            Id = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5d3e55d8-d911-4414-943b-5ef1d921e716",
                            Email = "guestTwo@mail.com",
                            EmailConfirmed = true,
                            FirstName = "GuestTwo",
                            IsForgotten = false,
                            LastName = "UserTwo",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUESTTWO@MAIL.COM",
                            NormalizedUserName = "GUESTTWO",
                            PasswordHash = "AQAAAAEAACcQAAAAEK6btrAJw6GzB+ms3fBoYmcGn3iP2O4NUTqt2jCkrdBaFlNQcTciiT3OHgSJla48oQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1819166a-7aa8-4419-9108-1f86208e6dbf",
                            TwoFactorEnabled = false,
                            UserName = "guestTwo"
                        },
                        new
                        {
                            Id = new Guid("56d7b046-a494-4ca4-bc9a-1689274adc6d"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c627b064-8125-4488-b2ab-f64c37690e09",
                            Email = "vassdeniss@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Denis",
                            IsForgotten = false,
                            LastName = "Vasilev",
                            LockoutEnabled = false,
                            NormalizedEmail = "VASSDENISS@GMAIL.COM",
                            NormalizedUserName = "VASSDENISS",
                            PasswordHash = "AQAAAAEAACcQAAAAEJbJd/KoBDVXWI/FafNwBOJwPJrvFbxWB2TBH0/yDii1ycArBbphGnGw5m5SXGACWg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "493db34e-a778-44b4-8ba5-57a25d62c505",
                            TwoFactorEnabled = false,
                            UserName = "vassdeniss"
                        });
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the unique GUID identifier for a comment.");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Gets or sets the content of the comment.");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the guid of the user who created the comment.");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Gets or sets the date & time a comment has been created on.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Gets or sets a value indicating whether a comment has been deleted.");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("bit")
                        .HasComment("Gets or sets a value indicating whether a comment has been edited.");

                    b.Property<Guid>("RankPageId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the guid of the ranking page where the comment was sent.");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("RankPageId");

                    b.ToTable("Comments");

                    b.HasComment("The 'Comment' model for the database.");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e2d86f38-5222-44f7-8ec3-a8ca61880f92"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("b54091aa-7e94-4378-881f-10b88a66ea22"),
                            CreatedOn = new DateTime(2022, 12, 6, 22, 18, 16, 174, DateTimeKind.Local).AddTicks(9991),
                            IsDeleted = false,
                            IsEdited = false,
                            RankPageId = new Guid("00302d44-25b1-4d29-892d-3a50adbb5916")
                        },
                        new
                        {
                            Id = new Guid("2ed6a2e4-e69c-4996-8be5-b760489eeb89"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("b54091aa-7e94-4378-881f-10b88a66ea22"),
                            CreatedOn = new DateTime(2022, 12, 11, 22, 18, 16, 174, DateTimeKind.Local).AddTicks(9997),
                            IsDeleted = false,
                            IsEdited = false,
                            RankPageId = new Guid("00302d44-25b1-4d29-892d-3a50adbb5916")
                        },
                        new
                        {
                            Id = new Guid("4cd91ec8-6c08-48bf-b678-e225b6cae76e"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 11, 29, 22, 18, 16, 175, DateTimeKind.Local).AddTicks(1),
                            IsDeleted = false,
                            IsEdited = false,
                            RankPageId = new Guid("00302d44-25b1-4d29-892d-3a50adbb5916")
                        });
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.EasyRankRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.EasyRankUserRankPage", b =>
                {
                    b.Property<Guid>("EasyRankUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RankPageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsLiked")
                        .HasColumnType("bit");

                    b.HasKey("EasyRankUserId", "RankPageId");

                    b.HasIndex("RankPageId");

                    b.ToTable("EasyRankUsersRankPages");
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.RankEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the unique GUID identifier for a rank entry.");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Gets or sets the description for a rank entry.");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)")
                        .HasComment("Gets or sets the image for a rank entry.");

                    b.Property<string>("ImageAlt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Gets or sets the alternative text if the image is broken.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Gets or sets a value indicating whether a rank entry has been deleted.");

                    b.Property<int>("Placement")
                        .HasColumnType("int")
                        .HasComment("Gets or sets the placement in the ranking of the ranking entry.");

                    b.Property<Guid>("RankPageId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the guid of the rank page which the entry belongs to.");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Gets or sets the title for a rank entry.");

                    b.HasKey("Id");

                    b.HasIndex("RankPageId");

                    b.ToTable("RankEntries");

                    b.HasComment("The 'RankEntry' model for the database.");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0bb58cdb-b35c-40cf-abd4-b38fc4ab4289"),
                            Description = "Good stuff",
                            ImageAlt = "Picture of star wars",
                            IsDeleted = false,
                            Placement = 10,
                            RankPageId = new Guid("00302d44-25b1-4d29-892d-3a50adbb5916"),
                            Title = "Star Wars"
                        },
                        new
                        {
                            Id = new Guid("667cd68e-8d56-4e35-89c4-ba8a4b1e040e"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque interdum iaculis arcu et pellentesque. Aliquam at venenatis libero. Suspendisse non suscipit mi, in ullamcorper magna. Donec imperdiet urna et aliquet placerat. Donec faucibus dolor id velit sagittis congue. In hac habitasse platea dictumst. Suspendisse vitae sodales diam. Mauris in erat magna. Cras molestie lectus felis, eget convallis lectus mollis ac. Proin posuere nec magna at accumsan. Etiam quis magna pulvinar, eleifend purus a, fringilla eros.",
                            ImageAlt = "Picture of star wars2",
                            IsDeleted = false,
                            Placement = 9,
                            RankPageId = new Guid("00302d44-25b1-4d29-892d-3a50adbb5916"),
                            Title = "Star Wars2"
                        });
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.RankPage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the unique GUID identifier for a ranking page.");

                    b.Property<Guid?>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the guid of the user who created the rank page.");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Gets or sets the date & time a ranking page has been created on.");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)")
                        .HasComment("Gets or sets the image for a rank entry.");

                    b.Property<string>("ImageAlt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Gets or sets the alternative text if the image is broken.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Gets or sets a value indicating whether a rank page has been deleted.");

                    b.Property<string>("RankingTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Gets or sets the name of the ranking page.");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("RankPages");

                    b.HasComment("The 'RankPage' model for the database.");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00302d44-25b1-4d29-892d-3a50adbb5916"),
                            CreatedByUserId = new Guid("b54091aa-7e94-4378-881f-10b88a66ea22"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 10 Best Movies of 2022"
                        },
                        new
                        {
                            Id = new Guid("3bc1dd9f-10e0-4dab-a98c-cf7a16f27659"),
                            CreatedByUserId = new Guid("b54091aa-7e94-4378-881f-10b88a66ea22"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("7dc8b324-f3d8-4bbd-b5a7-87a63de5ee0f"),
                            CreatedByUserId = new Guid("b54091aa-7e94-4378-881f-10b88a66ea22"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("c06b3f9f-5da2-4f56-86be-52f2290e862f"),
                            CreatedByUserId = new Guid("b54091aa-7e94-4378-881f-10b88a66ea22"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("7b398bcf-d75f-4aab-ab68-61eed483f1d1"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("c81a5fa4-9824-4ee6-b4c7-d1b4d557810c"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("602cbc35-3c31-4723-86bf-2cd277ed42c8"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("72568a40-d044-477a-9c77-50fcfaf6c794"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("09299c95-f379-46b0-8289-ffd73c3aeb5e"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("acbaaad8-f5d7-4253-b2d9-85058846f6bf"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("6cbe3e58-aed5-4362-9d78-0440d78f871e"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("e4e92bd4-380e-46e8-add6-6b17ce0b4d60"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("ee473563-f81b-4797-add5-13f109ac4d6f"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("a0b19af5-6bc5-4b68-92c5-deccc8ff909e"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("ad951ce9-d337-4aa9-85b5-18c3a1deed3b"),
                            CreatedByUserId = new Guid("a0790ac4-8b69-43a8-a6c7-f4ca6f835173"),
                            CreatedOn = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.Comment", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", "CreatedByUser")
                        .WithMany("UserComments")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyRank.Infrastructure.Models.RankPage", "RankPage")
                        .WithMany("Comments")
                        .HasForeignKey("RankPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("RankPage");
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.EasyRankUserRankPage", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", "EasyRankUser")
                        .WithMany("LikedRankings")
                        .HasForeignKey("EasyRankUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyRank.Infrastructure.Models.RankPage", "RankPage")
                        .WithMany("LikedBy")
                        .HasForeignKey("RankPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EasyRankUser");

                    b.Navigation("RankPage");
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.RankEntry", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.RankPage", "RankPage")
                        .WithMany("Entries")
                        .HasForeignKey("RankPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RankPage");
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.RankPage", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", "CreatedByUser")
                        .WithMany("UserRankings")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("CreatedByUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.EasyRankRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.EasyRankRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.Accounts.EasyRankUser", b =>
                {
                    b.Navigation("LikedRankings");

                    b.Navigation("UserComments");

                    b.Navigation("UserRankings");
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.RankPage", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Entries");

                    b.Navigation("LikedBy");
                });
#pragma warning restore 612, 618
        }
    }
}

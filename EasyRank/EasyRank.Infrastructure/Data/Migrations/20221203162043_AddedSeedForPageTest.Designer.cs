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
    [Migration("20221203162043_AddedSeedForPageTest")]
    partial class AddedSeedForPageTest
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
                            Id = new Guid("2a4be477-858d-4865-9819-97c326324e87"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ef336af9-a7b2-4fde-8465-bf8e8bea4900",
                            Email = "guest@mail.com",
                            EmailConfirmed = true,
                            FirstName = "Guest",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@MAIL.COM",
                            NormalizedUserName = "GUEST",
                            PasswordHash = "AQAAAAEAACcQAAAAEGhS+Jkk0bR/uPgllkx4vZWCuI8mBkewDTtk0LYIHIBBdZKzQMCYVdZpFwb1GuhA3w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "681517e2-991c-4017-8bf6-5fb9d7f60511",
                            TwoFactorEnabled = false,
                            UserName = "guest"
                        },
                        new
                        {
                            Id = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a4334fc0-262f-4605-9924-d32c88a84c14",
                            Email = "guestTwo@mail.com",
                            EmailConfirmed = true,
                            FirstName = "GuestTwo",
                            LastName = "UserTwo",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUESTTWO@MAIL.COM",
                            NormalizedUserName = "GUESTTWO",
                            PasswordHash = "AQAAAAEAACcQAAAAEBRPZNbW9haS6Ffd9SrLd1gL5Z/vOrkC41hnslKUf3Y6bRwbkP7MliJ+FLu/0AU0Xw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9946df9f-90b8-4530-bb75-a00b76a1e44f",
                            TwoFactorEnabled = false,
                            UserName = "guestTwo"
                        },
                        new
                        {
                            Id = new Guid("8c01156e-ce88-4b3b-9db5-40114c56adbf"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ca7f8613-d6a1-48fd-bed8-6dca96e64a4d",
                            Email = "vassdeniss@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Denis",
                            LastName = "Vasilev",
                            LockoutEnabled = false,
                            NormalizedEmail = "VASSDENISS@GMAIL.COM",
                            NormalizedUserName = "VASSDENISS",
                            PasswordHash = "AQAAAAEAACcQAAAAEDtwmnKbVttTVkwGXRwgVbxbCx3yJFbAcpAZgumgef0ehvUD1fwMLhiX73DDQnx7PQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3bd5b968-a857-45e4-a2bb-d80c7d2288a8",
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
                            Id = new Guid("9dc1c77f-bc53-4735-a0f3-fb3a9aaf8433"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("2a4be477-858d-4865-9819-97c326324e87"),
                            CreatedOn = new DateTime(2022, 11, 30, 18, 20, 42, 387, DateTimeKind.Local).AddTicks(3868),
                            IsDeleted = false,
                            IsEdited = false,
                            RankPageId = new Guid("d7a54530-fe81-4621-9db9-663269a9577a")
                        },
                        new
                        {
                            Id = new Guid("1f26c8ad-7dff-4085-b2d1-e5d645a7327a"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("2a4be477-858d-4865-9819-97c326324e87"),
                            CreatedOn = new DateTime(2022, 12, 5, 18, 20, 42, 387, DateTimeKind.Local).AddTicks(3877),
                            IsDeleted = false,
                            IsEdited = false,
                            RankPageId = new Guid("d7a54530-fe81-4621-9db9-663269a9577a")
                        },
                        new
                        {
                            Id = new Guid("533d2b67-f72b-48bb-84e0-2df65ad7eccc"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 11, 23, 18, 20, 42, 387, DateTimeKind.Local).AddTicks(3887),
                            IsDeleted = false,
                            IsEdited = false,
                            RankPageId = new Guid("d7a54530-fe81-4621-9db9-663269a9577a")
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
                            Id = new Guid("d510b449-3073-4591-b0ab-383cfe641aed"),
                            Description = "Good stuff",
                            ImageAlt = "Picture of star wars",
                            IsDeleted = false,
                            Placement = 10,
                            RankPageId = new Guid("d7a54530-fe81-4621-9db9-663269a9577a"),
                            Title = "Star Wars"
                        },
                        new
                        {
                            Id = new Guid("03ec1421-909e-409e-89f2-c723c8162ea3"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque interdum iaculis arcu et pellentesque. Aliquam at venenatis libero. Suspendisse non suscipit mi, in ullamcorper magna. Donec imperdiet urna et aliquet placerat. Donec faucibus dolor id velit sagittis congue. In hac habitasse platea dictumst. Suspendisse vitae sodales diam. Mauris in erat magna. Cras molestie lectus felis, eget convallis lectus mollis ac. Proin posuere nec magna at accumsan. Etiam quis magna pulvinar, eleifend purus a, fringilla eros.",
                            ImageAlt = "Picture of star wars2",
                            IsDeleted = false,
                            Placement = 9,
                            RankPageId = new Guid("d7a54530-fe81-4621-9db9-663269a9577a"),
                            Title = "Star Wars2"
                        });
                });

            modelBuilder.Entity("EasyRank.Infrastructure.Models.RankPage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the unique GUID identifier for a ranking page.");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Gets or sets the guid of the user who created the ranking page.");

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
                            Id = new Guid("d7a54530-fe81-4621-9db9-663269a9577a"),
                            CreatedByUserId = new Guid("2a4be477-858d-4865-9819-97c326324e87"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 10 Best Movies of 2022"
                        },
                        new
                        {
                            Id = new Guid("c5713437-504c-4a71-ac63-fe2b4fe87e08"),
                            CreatedByUserId = new Guid("2a4be477-858d-4865-9819-97c326324e87"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("9e4ef54b-ac13-468c-946a-fd2055177359"),
                            CreatedByUserId = new Guid("2a4be477-858d-4865-9819-97c326324e87"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("9c34d38b-8633-4d5b-ace9-06580e52988a"),
                            CreatedByUserId = new Guid("2a4be477-858d-4865-9819-97c326324e87"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("30f1c5f0-3dab-479d-a127-8a605a2640cf"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("224d2e32-8621-4d2f-96f8-cac781a5958e"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("1942ad00-d61a-4aed-a745-001de176e9b6"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("85a16897-5767-45dc-9bc7-075fade58487"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("8a4fbb46-e455-444f-ace2-94ab83c664a2"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("96808fac-4345-4284-b848-5dd1be055af7"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("32d7b600-8d86-4d99-85ca-0063dc20061c"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("7dc172ee-2263-4e6a-8fb4-cafebe056cbb"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("a3ef4857-a28a-4b50-853e-a59dc91b86da"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("62cbd76a-78e9-48c2-956b-351f37c24d5a"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("fb2c2ede-ef76-4588-82d8-766ca3f10a4d"),
                            CreatedByUserId = new Guid("e1eb8808-ca71-4981-8866-da1a3ff29d25"),
                            CreatedOn = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

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
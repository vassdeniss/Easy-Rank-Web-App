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
    [Migration("20221127190448_AddedEntryDeleteFlag")]
    partial class AddedEntryDeleteFlag
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
                            Id = new Guid("65bd6f38-41cc-4b6b-99c2-133d5996b845"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "31d88ac1-35c7-4367-99b5-dac3765da779",
                            Email = "guest@mail.com",
                            EmailConfirmed = true,
                            FirstName = "Guest",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@MAIL.COM",
                            NormalizedUserName = "GUEST",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ7kO5l3qMxZOHvFHA410GHMC7R6AsRCld9OIWUx4UYTOVznk0zt2SkLLNHh6rknIQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0f3775aa-62ce-47ec-9715-7ba233003a98",
                            TwoFactorEnabled = false,
                            UserName = "guest"
                        },
                        new
                        {
                            Id = new Guid("6520a520-6658-4fa4-bd09-136af100ff25"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3c4f26ce-4a71-4482-b10a-b3d43eea701a",
                            Email = "guestTwo@mail.com",
                            EmailConfirmed = true,
                            FirstName = "GuestTwo",
                            LastName = "UserTwo",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUESTTWO@MAIL.COM",
                            NormalizedUserName = "GUESTTWO",
                            PasswordHash = "AQAAAAEAACcQAAAAEIEGA6/0m0o5pXWvmuPSKe1nMa8czz4MKgeVVjOfLeXkkwi9Jf3zyrjMhoQTACk8xA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b75f8243-9bb1-4a08-a743-d0b965951853",
                            TwoFactorEnabled = false,
                            UserName = "guestTwo"
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
                            Id = new Guid("8c14bfaf-a9fb-44c6-9297-a9f3890d30a5"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("65bd6f38-41cc-4b6b-99c2-133d5996b845"),
                            CreatedOn = new DateTime(2022, 11, 24, 21, 4, 48, 210, DateTimeKind.Local).AddTicks(1805),
                            IsDeleted = false,
                            RankPageId = new Guid("bcc19f85-7173-4746-bd9e-066cc5420098")
                        },
                        new
                        {
                            Id = new Guid("2402043d-ab97-49c9-8da0-2a9436d31448"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("65bd6f38-41cc-4b6b-99c2-133d5996b845"),
                            CreatedOn = new DateTime(2022, 11, 29, 21, 4, 48, 210, DateTimeKind.Local).AddTicks(1813),
                            IsDeleted = false,
                            RankPageId = new Guid("bcc19f85-7173-4746-bd9e-066cc5420098")
                        },
                        new
                        {
                            Id = new Guid("6bf9b3ed-1410-4985-92c1-450eb08775d8"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByUserId = new Guid("6520a520-6658-4fa4-bd09-136af100ff25"),
                            CreatedOn = new DateTime(2022, 11, 17, 21, 4, 48, 210, DateTimeKind.Local).AddTicks(1821),
                            IsDeleted = false,
                            RankPageId = new Guid("bcc19f85-7173-4746-bd9e-066cc5420098")
                        });
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
                            Id = new Guid("362e80c1-4468-48b6-bccb-2342b38c1e5b"),
                            Description = "Good stuff",
                            ImageAlt = "Picture of star wars",
                            IsDeleted = false,
                            Placement = 10,
                            RankPageId = new Guid("bcc19f85-7173-4746-bd9e-066cc5420098"),
                            Title = "Star Wars"
                        },
                        new
                        {
                            Id = new Guid("30c99386-041e-4624-9284-68a1a79b61ac"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque interdum iaculis arcu et pellentesque. Aliquam at venenatis libero. Suspendisse non suscipit mi, in ullamcorper magna. Donec imperdiet urna et aliquet placerat. Donec faucibus dolor id velit sagittis congue. In hac habitasse platea dictumst. Suspendisse vitae sodales diam. Mauris in erat magna. Cras molestie lectus felis, eget convallis lectus mollis ac. Proin posuere nec magna at accumsan. Etiam quis magna pulvinar, eleifend purus a, fringilla eros.",
                            ImageAlt = "Picture of star wars2",
                            IsDeleted = false,
                            Placement = 9,
                            RankPageId = new Guid("bcc19f85-7173-4746-bd9e-066cc5420098"),
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
                            Id = new Guid("bcc19f85-7173-4746-bd9e-066cc5420098"),
                            CreatedByUserId = new Guid("65bd6f38-41cc-4b6b-99c2-133d5996b845"),
                            CreatedOn = new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 10 Best Movies of 2022"
                        },
                        new
                        {
                            Id = new Guid("988effcd-d069-42c7-8b17-b192709a75ab"),
                            CreatedByUserId = new Guid("65bd6f38-41cc-4b6b-99c2-133d5996b845"),
                            CreatedOn = new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("a7053062-07e5-451f-afe7-7cd444dd32e6"),
                            CreatedByUserId = new Guid("65bd6f38-41cc-4b6b-99c2-133d5996b845"),
                            CreatedOn = new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("f15e1a70-0d7e-42b6-857a-1d03debe81d9"),
                            CreatedByUserId = new Guid("65bd6f38-41cc-4b6b-99c2-133d5996b845"),
                            CreatedOn = new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        },
                        new
                        {
                            Id = new Guid("cdcfe08d-2512-4cfb-b46c-57d5baf37993"),
                            CreatedByUserId = new Guid("6520a520-6658-4fa4-bd09-136af100ff25"),
                            CreatedOn = new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            ImageAlt = "Yoda",
                            IsDeleted = false,
                            RankingTitle = "Top 5 Favorite Characters"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
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
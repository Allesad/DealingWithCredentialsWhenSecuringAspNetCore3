﻿// <auto-generated />
using System;
using Marvin.IDP.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marvin.IDP.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20200512211718_AddEmailAddress")]
    partial class AddEmailAddress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Marvin.IDP.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("SecurityCodeExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Subject")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Active = true,
                            ConcurrencyStamp = "8b4358fb-9269-44c5-905f-6fffbb790a40",
                            Password = "password",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            Username = "Frank"
                        },
                        new
                        {
                            Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Active = true,
                            ConcurrencyStamp = "5e6521ab-a178-4434-9106-b7335b332758",
                            Password = "password",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                            Username = "Claire"
                        });
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b41d953-56f7-4e8a-b597-7e07668204c8"),
                            ConcurrencyStamp = "30bf7565-b633-478e-931c-42f1ccdfadf7",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Frank"
                        },
                        new
                        {
                            Id = new Guid("f4e4630d-5912-4a51-98b2-95e71d897f1d"),
                            ConcurrencyStamp = "34fc5346-10cb-41cd-be41-a6dc1b632531",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Underwood"
                        },
                        new
                        {
                            Id = new Guid("0c626567-df4a-4884-8126-ccfc4017c46b"),
                            ConcurrencyStamp = "8648df49-8eb8-4e5f-b965-8108d871c289",
                            Type = "email",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "frank@someprovider.com"
                        },
                        new
                        {
                            Id = new Guid("10f9fa07-4565-46f7-a9b8-b3086dc61162"),
                            ConcurrencyStamp = "0ebe485c-633d-4d1e-b71c-7be44c99a6d6",
                            Type = "address",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Main Road 1"
                        },
                        new
                        {
                            Id = new Guid("fbbef130-af70-466b-a9da-3c6d967c90f8"),
                            ConcurrencyStamp = "bda84c06-f1bd-41ef-bda5-823f66a234e1",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "nl"
                        },
                        new
                        {
                            Id = new Guid("c9847835-583e-4eee-b8e7-1b88016ab5dc"),
                            ConcurrencyStamp = "c090c516-ed43-4ff0-b1d9-ca3e921f2c8c",
                            Type = "given_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Claire"
                        },
                        new
                        {
                            Id = new Guid("18bd0261-54a4-4e7d-8afd-083672825cd3"),
                            ConcurrencyStamp = "2eef76ae-e490-4b5e-8749-3171574ced5a",
                            Type = "family_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Underwood"
                        },
                        new
                        {
                            Id = new Guid("3009ab25-7710-404b-82b8-4ba78c715fc4"),
                            ConcurrencyStamp = "46d2996c-9980-4da3-b58f-b8779abad3a2",
                            Type = "email",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "claire@someprovider.com"
                        },
                        new
                        {
                            Id = new Guid("a19eee0d-4e7d-42af-8644-63efab0dec1d"),
                            ConcurrencyStamp = "7d40f5c1-969c-4e5f-98df-6000964a9643",
                            Type = "address",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Big Street 2"
                        },
                        new
                        {
                            Id = new Guid("0a74f90c-0630-4035-b542-37d2f262fd8c"),
                            ConcurrencyStamp = "cdafc903-6c73-4ba8-af11-666440957ba5",
                            Type = "country",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "be"
                        });
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserClaim", b =>
                {
                    b.HasOne("Marvin.IDP.Entities.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

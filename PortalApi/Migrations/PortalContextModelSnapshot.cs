﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalApi.Contexts;

namespace PortalApi.Migrations
{
    [DbContext(typeof(PortalContext))]
    partial class PortalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortalApi.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleSubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(2500)")
                        .HasMaxLength(2500);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ArticleSubCategoryId");

                    b.HasIndex("PersonId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleSubCategoryId = 1,
                            Content = "Rozmowy1_Content",
                            Date = new DateTime(2020, 5, 29, 21, 9, 5, 807, DateTimeKind.Local).AddTicks(7558),
                            ImgSrc = "sciezka IMG 1",
                            PersonId = 1,
                            Title = "Rozmowy1-Title"
                        },
                        new
                        {
                            Id = 2,
                            ArticleSubCategoryId = 1,
                            Content = "Rozmowy2_Content",
                            Date = new DateTime(2020, 5, 30, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(574),
                            ImgSrc = "sciezka IMG 2",
                            PersonId = 1,
                            Title = "Rozmowy2-Title"
                        },
                        new
                        {
                            Id = 3,
                            ArticleSubCategoryId = 1,
                            Content = "Rozmowy3e_Content",
                            Date = new DateTime(2020, 5, 31, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(614),
                            ImgSrc = "sciezka IMG 3",
                            PersonId = 1,
                            Title = "Rozmowy3e-Title"
                        },
                        new
                        {
                            Id = 4,
                            ArticleSubCategoryId = 1,
                            Content = "Rozmowy4_Content",
                            Date = new DateTime(2020, 6, 1, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(620),
                            ImgSrc = "sciezka IMG 4",
                            PersonId = 1,
                            Title = "Rozmowy4-Title"
                        },
                        new
                        {
                            Id = 5,
                            ArticleSubCategoryId = 1,
                            Content = "Rozmowy5_Content",
                            Date = new DateTime(2020, 6, 2, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(624),
                            ImgSrc = "sciezka IMG 5",
                            PersonId = 1,
                            Title = "Rozmowy5-Title"
                        },
                        new
                        {
                            Id = 6,
                            ArticleSubCategoryId = 2,
                            Content = "Wydarzenia1_Content",
                            Date = new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(628),
                            ImgSrc = "sciezka IMG 1",
                            PersonId = 2,
                            Title = "Wydarzenia1-Title"
                        },
                        new
                        {
                            Id = 7,
                            ArticleSubCategoryId = 2,
                            Content = "Wydarzenia2_Content",
                            Date = new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(632),
                            ImgSrc = "sciezka IMG 2",
                            PersonId = 2,
                            Title = "Wydarzenia2-Title"
                        },
                        new
                        {
                            Id = 8,
                            ArticleSubCategoryId = 2,
                            Content = "Wydarzenia3_Content",
                            Date = new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(635),
                            ImgSrc = "sciezka IMG 3",
                            PersonId = 2,
                            Title = "Wydarzenia3-Title"
                        },
                        new
                        {
                            Id = 9,
                            ArticleSubCategoryId = 2,
                            Content = "Wydarzenia4_Content",
                            Date = new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(639),
                            ImgSrc = "sciezka IMG 4",
                            PersonId = 2,
                            Title = "Wydarzenia4-Title"
                        },
                        new
                        {
                            Id = 10,
                            ArticleSubCategoryId = 2,
                            Content = "Wydarzenia5_Content",
                            Date = new DateTime(2020, 5, 28, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(643),
                            ImgSrc = "sciezka IMG 5",
                            PersonId = 2,
                            Title = "Wydarzenia5-Title"
                        });
                });

            modelBuilder.Entity("PortalApi.Entities.ArticleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ArticleCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tatuaż"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Piercing"
                        });
                });

            modelBuilder.Entity("PortalApi.Entities.ArticleSubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ArticleCategoryId");

                    b.ToTable("ArticleSubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleCategoryId = 1,
                            Name = "Rozmowy"
                        },
                        new
                        {
                            Id = 2,
                            ArticleCategoryId = 1,
                            Name = "Wydarzenia"
                        },
                        new
                        {
                            Id = 3,
                            ArticleCategoryId = 1,
                            Name = "Porady o tatuażu"
                        },
                        new
                        {
                            Id = 4,
                            ArticleCategoryId = 1,
                            Name = "Relacje"
                        },
                        new
                        {
                            Id = 5,
                            ArticleCategoryId = 1,
                            Name = "Różne"
                        },
                        new
                        {
                            Id = 6,
                            ArticleCategoryId = 1,
                            Name = "Ze świata"
                        },
                        new
                        {
                            Id = 7,
                            ArticleCategoryId = 1,
                            Name = "Oferty pracy"
                        },
                        new
                        {
                            Id = 8,
                            ArticleCategoryId = 2,
                            Name = "O przekłuciu"
                        },
                        new
                        {
                            Id = 9,
                            ArticleCategoryId = 2,
                            Name = "Porady"
                        },
                        new
                        {
                            Id = 10,
                            ArticleCategoryId = 2,
                            Name = "Rozmowy"
                        },
                        new
                        {
                            Id = 11,
                            ArticleCategoryId = 2,
                            Name = "Różne"
                        });
                });

            modelBuilder.Entity("PortalApi.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("PortalApi.Entities.Tattoo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Tattoos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 6, 9, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(2614),
                            ImgSrc = "sciezka TATTOO 1",
                            PersonId = 1,
                            Style = "A1"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 6, 10, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(3493),
                            ImgSrc = "sciezka TATTOO 2",
                            PersonId = 1,
                            Style = "A2"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2020, 6, 11, 21, 9, 5, 811, DateTimeKind.Local).AddTicks(3518),
                            ImgSrc = "sciezka TATTOO 3",
                            PersonId = 2,
                            Style = "A1"
                        });
                });

            modelBuilder.Entity("PortalApi.Entities.Article", b =>
                {
                    b.HasOne("PortalApi.Entities.ArticleSubCategory", "ArticleSubCategory")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleSubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalApi.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortalApi.Entities.ArticleSubCategory", b =>
                {
                    b.HasOne("PortalApi.Entities.ArticleCategory", "ArticleCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ArticleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortalApi.Entities.Tattoo", b =>
                {
                    b.HasOne("PortalApi.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

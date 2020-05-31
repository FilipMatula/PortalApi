﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using PortalApi.Entities;
using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Contexts
{
    public class PortalContext : DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options)
        : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<ArticleSubCategory> ArticleSubCategories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tattoo> Tattoos { get; set; }
        public DbSet<Piercing> Piercings { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Photographer> Photographers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // seed the database with dummy data
            modelBuilder.Entity<ArticleCategory>().HasData(
                new ArticleCategory()
                {
                    Id = 1,
                    Name = "Tatuaż"
                },
                new ArticleCategory()
                {
                    Id = 2,
                    Name = "Piercing"
                }
                );

            modelBuilder.Entity<ArticleSubCategory>().HasData(
                new ArticleSubCategory()
                {
                    Id = 1,
                    Name = "Rozmowy",
                    ArticleCategoryId = 1
                },
                new ArticleSubCategory()
                {
                    Id = 2,
                    Name = "Wydarzenia",
                    ArticleCategoryId = 1
                },
                new ArticleSubCategory()
                {
                    Id = 3,
                    Name = "Porady o tatuażu",
                    ArticleCategoryId = 1
                },
                new ArticleSubCategory()
                {
                    Id = 4,
                    Name = "Relacje",
                    ArticleCategoryId = 1
                },
                new ArticleSubCategory()
                {
                    Id = 5,
                    Name = "Różne",
                    ArticleCategoryId = 1
                },
                new ArticleSubCategory()
                {
                    Id = 6,
                    Name = "Ze świata",
                    ArticleCategoryId = 1
                },
                new ArticleSubCategory()
                {
                    Id = 7,
                    Name = "Oferty pracy",
                    ArticleCategoryId = 1
                },
                new ArticleSubCategory()
                {
                    Id = 8,
                    Name = "O przekłuciu",
                    ArticleCategoryId = 2
                },
                new ArticleSubCategory()
                {
                    Id = 9,
                    Name = "Porady",
                    ArticleCategoryId = 2
                },
                new ArticleSubCategory()
                {
                    Id = 10,
                    Name = "Rozmowy",
                    ArticleCategoryId = 2
                },
                new ArticleSubCategory()
                {
                    Id = 11,
                    Name = "Różne",
                    ArticleCategoryId = 2
                }
                );

            modelBuilder.Entity<Person>().HasData(
               new Person
               {
                   Id = 1,
                   UserId = 1
               },
               new Person
               {
                   Id = 2,
                   UserId = 2
               },
               new Person
               {
                   Id = 3,
                   UserId = 3
               }
               );

            modelBuilder.Entity<Article>().HasData(
               new Article
               {
                   Id = 1,
                   PersonId = 1,
                   ArticleSubCategoryId = 1,
                   Title = "Rozmowy1-Title",
                   Content = "Rozmowy1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "sciezka IMG 1"
               },
               new Article
               {
                   Id = 2,
                   PersonId = 1,
                   ArticleSubCategoryId = 1,
                   Title = "Rozmowy2-Title",
                   Content = "Rozmowy2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "sciezka IMG 2"
               },
               new Article
               {
                   Id = 3,
                   PersonId = 1,
                   ArticleSubCategoryId = 1,
                   Title = "Rozmowy3e-Title",
                   Content = "Rozmowy3e_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "sciezka IMG 3"
               },
               new Article
               {
                   Id = 4,
                   PersonId = 1,
                   ArticleSubCategoryId = 1,
                   Title = "Rozmowy4-Title",
                   Content = "Rozmowy4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "sciezka IMG 4"
               },
               new Article
               {
                   Id = 5,
                   PersonId = 1,
                   ArticleSubCategoryId = 1,
                   Title = "Rozmowy5-Title",
                   Content = "Rozmowy5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "sciezka IMG 5"
               },
               new Article
               {
                   Id = 6,
                   PersonId = 2,
                   ArticleSubCategoryId = 2,
                   Title = "Wydarzenia1-Title",
                   Content = "Wydarzenia1_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 1"
               },
               new Article
               {
                   Id = 7,
                   PersonId = 2,
                   ArticleSubCategoryId = 2,
                   Title = "Wydarzenia2-Title",
                   Content = "Wydarzenia2_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 2"
               },
               new Article
               {
                   Id = 8,
                   PersonId = 2,
                   ArticleSubCategoryId = 2,
                   Title = "Wydarzenia3-Title",
                   Content = "Wydarzenia3_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 3"
               },
               new Article
               {
                   Id = 9,
                   PersonId = 2,
                   ArticleSubCategoryId = 2,
                   Title = "Wydarzenia4-Title",
                   Content = "Wydarzenia4_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 4"
               },
               new Article
               {
                   Id = 10,
                   PersonId = 2,
                   ArticleSubCategoryId = 2,
                   Title = "Wydarzenia5-Title",
                   Content = "Wydarzenia5_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 5"
               }
               );

            modelBuilder.Entity<Tattoo>().HasData(
               new Tattoo
               {
                   Id = 1,
                   PersonId = 1,
                   City = "Rzeszow",
                   Style = Style.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Technika1,
                   Gender = Gender.Kobieta,
                   Date = DateTime.Now.AddDays(12),
                   ImgSrc = "sciezka TATTOO 1"
               },
               new Tattoo
               {
                   Id = 2,
                   PersonId = 1,
                   City = "Warszawa",
                   Style = Style.Styl2,
                   Color = Color.Czarny,
                   Technique = Technique.Technika2,
                   Gender = Gender.Mężczyzna,
                   Date = DateTime.Now.AddDays(13),
                   ImgSrc = "sciezka TATTOO 2"
               },
               new Tattoo
               {
                   Id = 3,
                   PersonId = 2,
                   City = "Krakow",
                   Style = Style.Styl3,
                   Color = Color.Kolorowy,
                   Technique = Technique.Technika1,
                   Gender = Gender.Kobieta,
                   Date = DateTime.Now.AddDays(14),
                   ImgSrc = "sciezka TATTOO 3"
               }
               );

            modelBuilder.Entity<Piercing>().HasData(
              new Piercing
              {
                  Id = 1,
                  PersonId = 1,
                  City = "Krakow",
                  Pierce = Pierce.Przeklucie1,
                  Gender = Gender.Kobieta,
                  ImgSrc = "sciezka PIERCING 1",
                  Date = DateTime.Now.AddDays(1)
              },
              new Piercing
              {
                  Id = 2,
                  PersonId = 1,
                  City = "Wroclaw",
                  Pierce = Pierce.Przeklucie2,
                  Gender = Gender.Mężczyzna,
                  ImgSrc = "sciezka PIERCING 2",
                  Date = DateTime.Now.AddDays(2)
              },
              new Piercing
              {
                  Id = 3,
                  PersonId = 2,
                  City = "Poznan",
                  Pierce = Pierce.Przeklucie3,
                  Gender = Gender.Mężczyzna,
                  ImgSrc = "sciezka PIERCING 3",
                  Date = DateTime.Now.AddDays(3)
              }
              );

            modelBuilder.Entity<Model>().HasData(
              new Model
              {
                  Id = 1,
                  PersonId = 1,
                  City = "Krakow",
                  Gender = Gender.Kobieta,
                  About = "about me - model 1",
                  Media = "/facebook ; /Twitter ; /Instagram",
                  Piercing = true,
                  Tattoo = false,
                  ImgSrc = "sciezka MODEL 1",
                  Date = DateTime.Now.AddDays(33)
              },
              new Model
              {
                  Id = 2,
                  PersonId = 2,
                  City = "Warszawa",
                  Gender = Gender.Mężczyzna,
                  About = "about me - model 2",
                  Media = "/facebook ; /Twitter ; /Instagram",
                  Piercing = true,
                  Tattoo = true,
                  ImgSrc = "sciezka MODEL 2",
                  Date = DateTime.Now.AddDays(34)
              },
              new Model
              {
                  Id = 3,
                  PersonId = 3,
                  City = "Poznan",
                  Gender = Gender.Kobieta,
                  About = "about me - model 3",
                  Media = "/facebook ; /Twitter ; /Instagram",
                  Piercing = false,
                  Tattoo = false,
                  ImgSrc = "sciezka MODEL 3",
                  Date = DateTime.Now.AddDays(34)
              }
              );

            modelBuilder.Entity<Photographer>().HasData(
              new Photographer
              {
                  Id = 1,
                  PersonId = 1,
                  City = "Krakow",
                  Gender = Gender.Kobieta,
                  About = "about me - photographer 1",
                  Media = "/facebook ; /Twitter ; /Instagram",
                  ImgSrc = "sciezka Photographer 1",
                  Date = DateTime.Now.AddDays(11)
              },
              new Photographer
              {
                  Id = 2,
                  PersonId = 2,
                  City = "Warszawa",
                  Gender = Gender.Mężczyzna,
                  About = "about me - photographer 2",
                  Media = "/facebook ; /Twitter ; /Instagram",
                  ImgSrc = "sciezka Photographer 2",
                  Date = DateTime.Now.AddDays(22)
              },
              new Photographer
              {
                  Id = 3,
                  PersonId = 3,
                  City = "Poznan",
                  Gender = Gender.Kobieta,
                  About = "about me - photographer 3",
                  Media = "/facebook ; /Twitter ; /Instagram",
                  ImgSrc = "sciezka Photographer 3",
                  Date = DateTime.Now.AddDays(33)
              }
              );

            base.OnModelCreating(modelBuilder);
        }

    }
}

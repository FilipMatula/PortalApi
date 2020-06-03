using Microsoft.EntityFrameworkCore;
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
        public DbSet<ArticleSubcategory> ArticleSubCategories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tattoo> Tattoos { get; set; }
        public DbSet<Piercing> Piercings { get; set; }
        public DbSet<ModelPhoto> ModelsPhotos { get; set; }
        public DbSet<PhotographerPhoto> PhotographersPhotos { get; set; }
        public DbSet<AvailableDesign> AvailableDesigns { get; set; }
        public DbSet<Piercer> Piercers { get; set; }
        public DbSet<Tattooer> Tattooers { get; set; }
        public DbSet<Model> Models { get; set; }


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
                },
                new ArticleCategory()
                {
                    Id = 3,
                    Name = "Modeling"
                },
                new ArticleCategory()
                {
                    Id = 4,
                    Name = "Fotografia"
                }
                );

            modelBuilder.Entity<ArticleSubcategory>().HasData(
                new ArticleSubcategory()
                {
                    Id = 1,
                    Name = "Rozmowy",
                    ArticleCategoryId = 1
                },
                new ArticleSubcategory()
                {
                    Id = 2,
                    Name = "Wydarzenia",
                    ArticleCategoryId = 1
                },
                new ArticleSubcategory()
                {
                    Id = 3,
                    Name = "Porady o tatuażu",
                    ArticleCategoryId = 1
                },
                new ArticleSubcategory()
                {
                    Id = 4,
                    Name = "Relacje",
                    ArticleCategoryId = 1
                },
                new ArticleSubcategory()
                {
                    Id = 5,
                    Name = "Różne",
                    ArticleCategoryId = 1
                },
                new ArticleSubcategory()
                {
                    Id = 6,
                    Name = "Ze świata",
                    ArticleCategoryId = 1
                },
                new ArticleSubcategory()
                {
                    Id = 7,
                    Name = "Oferty pracy",
                    ArticleCategoryId = 1
                },
                new ArticleSubcategory()
                {
                    Id = 8,
                    Name = "O przekłuciu",
                    ArticleCategoryId = 2
                },
                new ArticleSubcategory()
                {
                    Id = 9,
                    Name = "Porady",
                    ArticleCategoryId = 2
                },
                new ArticleSubcategory()
                {
                    Id = 10,
                    Name = "Rozmowy",
                    ArticleCategoryId = 2
                },
                new ArticleSubcategory()
                {
                    Id = 11,
                    Name = "Różne",
                    ArticleCategoryId = 2
                },
                new ArticleSubcategory()
                {
                    Id = 12,
                    Name = "Rozmowy",
                    ArticleCategoryId = 3
                },
                new ArticleSubcategory()
                {
                    Id = 13,
                    Name = "Różne",
                    ArticleCategoryId = 3
                },
                new ArticleSubcategory()
                {
                    Id = 14,
                    Name = "Rozmowy",
                    ArticleCategoryId = 4
                },
                new ArticleSubcategory()
                {
                    Id = 15,
                    Name = "Różne",
                    ArticleCategoryId = 4
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
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy1-Title",
                   Content = "Rozmowy1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "sciezka IMG 1"
               },
               new Article
               {
                   Id = 2,
                   PersonId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy2-Title",
                   Content = "Rozmowy2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "sciezka IMG 2"
               },
               new Article
               {
                   Id = 3,
                   PersonId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy3e-Title",
                   Content = "Rozmowy3e_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "sciezka IMG 3"
               },
               new Article
               {
                   Id = 4,
                   PersonId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy4-Title",
                   Content = "Rozmowy4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "sciezka IMG 4"
               },
               new Article
               {
                   Id = 5,
                   PersonId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy5-Title",
                   Content = "Rozmowy5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "sciezka IMG 5"
               },
               new Article
               {
                   Id = 6,
                   PersonId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia1-Title",
                   Content = "Wydarzenia1_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 1"
               },
               new Article
               {
                   Id = 7,
                   PersonId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia2-Title",
                   Content = "Wydarzenia2_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 2"
               },
               new Article
               {
                   Id = 8,
                   PersonId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia3-Title",
                   Content = "Wydarzenia3_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 3"
               },
               new Article
               {
                   Id = 9,
                   PersonId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia4-Title",
                   Content = "Wydarzenia4_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 4"
               },
               new Article
               {
                   Id = 10,
                   PersonId = 2,
                   ArticleSubcategoryId = 2,
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
                   Technique = Technique.Handpoke,
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
                   Technique = Technique.Maszynka,
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
                   Technique = Technique.Handpoke,
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
                  Puncture = Puncture.Przeklucie1,
                  Gender = Gender.Kobieta,
                  ImgSrc = "sciezka PIERCING 1",
                  Date = DateTime.Now.AddDays(1)
              },
              new Piercing
              {
                  Id = 2,
                  PersonId = 1,
                  City = "Wroclaw",
                  Puncture = Puncture.Przeklucie2,
                  Gender = Gender.Mężczyzna,
                  ImgSrc = "sciezka PIERCING 2",
                  Date = DateTime.Now.AddDays(2)
              },
              new Piercing
              {
                  Id = 3,
                  PersonId = 2,
                  City = "Poznan",
                  Puncture = Puncture.Przeklucie3,
                  Gender = Gender.Mężczyzna,
                  ImgSrc = "sciezka PIERCING 3",
                  Date = DateTime.Now.AddDays(3)
              }
              );

            modelBuilder.Entity<ModelPhoto>().HasData(
              new ModelPhoto
              {
                  Id = 1,
                  PersonId = 1,
                  City = "Krakow",
                  Gender = Gender.Kobieta,
                  Puncture = true,
                  Tattoo = false,
                  ImgSrc = "sciezka MODEL 1",
                  Date = DateTime.Now.AddDays(33)
              },
              new ModelPhoto
              {
                  Id = 2,
                  PersonId = 2,
                  City = "Warszawa",
                  Gender = Gender.Mężczyzna,
                  Puncture = true,
                  Tattoo = true,
                  ImgSrc = "sciezka MODEL 2",
                  Date = DateTime.Now.AddDays(34)
              },
              new ModelPhoto
              {
                  Id = 3,
                  PersonId = 3,
                  City = "Poznan",
                  Gender = Gender.Kobieta,
                  Puncture = false,
                  Tattoo = false,
                  ImgSrc = "sciezka MODEL 3",
                  Date = DateTime.Now.AddDays(34)
              }
              );

            modelBuilder.Entity<PhotographerPhoto>().HasData(
              new PhotographerPhoto
              {
                  Id = 1,
                  PersonId = 1,
                  City = "Krakow",
                  Experience = Experience.Duże,
                  Gender = Gender.Kobieta,
                  ImgSrc = "sciezka Photographer 1",
                  Date = DateTime.Now.AddDays(11)
              },
              new PhotographerPhoto
              {
                  Id = 2,
                  PersonId = 2,
                  City = "Warszawa",
                  Experience = Experience.Niewielkie,
                  Gender = Gender.Mężczyzna,
                  ImgSrc = "sciezka Photographer 2",
                  Date = DateTime.Now.AddDays(22)
              },
              new PhotographerPhoto
              {
                  Id = 3,
                  PersonId = 3,
                  City = "Poznan",
                  Experience = Experience.Średnie,
                  Gender = Gender.Kobieta,
                  ImgSrc = "sciezka Photographer 3",
                  Date = DateTime.Now.AddDays(33)
              }
              );

            modelBuilder.Entity<AvailableDesign>().HasData(
                  new AvailableDesign
                  {
                      Id = 1,
                      PersonId = 1,
                      City = "Warszawa",
                      Style = Style.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Gender = Gender.Mężczyzna,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(1),
                      ImgSrc = "sciezka Available Design 1"
                  },
                  new AvailableDesign
                  {
                      Id = 2,
                      PersonId = 2,
                      City = "Poznan",
                      Style = Style.Styl2,
                      Color = Color.Kolorowy,
                      Technique = Technique.Maszynka,
                      Gender = Gender.Kobieta,
                      Price = 300,
                      Reserved = true,
                      Date = DateTime.Now.AddDays(2),
                      ImgSrc = "sciezka Available Design 2"
                  },
                  new AvailableDesign
                  {
                      Id = 3,
                      PersonId = 3,
                      City = "Krakow",
                      Style = Style.Styl3,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Gender = Gender.Kobieta,
                      Price = 199.99,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(3),
                      ImgSrc = "sciezka Available Design 3"
                  }
                    );

            modelBuilder.Entity<Country>().HasData(
                new Country()
                {
                    Id = 1,
                    Name = "Polska"
                },
                new Country()
                {
                    Id = 2,
                    Name = "Niemcy"
                },
                new Country()
                {
                    Id = 3,
                    Name = "Francja"
                }
                );

            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 1,
                    Name = "Warszawa",
                    CountryId = 1
                },
                new City()
                {
                    Id = 2,
                    Name = "Krakow",
                    CountryId = 1
                },
                new City()
                {
                    Id = 3,
                    Name = "Wroclaw",
                    CountryId = 1
                },
                new City()
                {
                    Id = 4,
                    Name = "Berlin",
                    CountryId = 2
                },
                new City()
                {
                    Id = 5,
                    Name = "Monachium",
                    CountryId = 2
                },
                new City()
                {
                    Id = 6,
                    Name = "Frankfurt",
                    CountryId = 2
                },
                new City()
                {
                    Id = 7,
                    Name = "Paryż",
                    CountryId = 3
                }
                );


            base.OnModelCreating(modelBuilder);
        }

    }
}

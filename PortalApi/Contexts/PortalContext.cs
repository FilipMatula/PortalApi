using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using PortalApi.Entities;
using PortalApi.ProfilesProperties;
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
        public DbSet<Photographer> Photographers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // seed the database with dummy data
            modelBuilder.Entity<ArticleCategory>().HasData(
                new ArticleCategory()
                {
                    Id = 1,
                    Name = "Tatuaż",
                    ArticleType = ArticleType.Tattoo
                },
                new ArticleCategory()
                {
                    Id = 2,
                    Name = "Piercing",
                    ArticleType = ArticleType.Piercing
                },
                new ArticleCategory()
                {
                    Id = 3,
                    Name = "Modeling",
                    ArticleType = ArticleType.Modeling
                },
                new ArticleCategory()
                {
                    Id = 4,
                    Name = "Fotografia",
                    ArticleType = ArticleType.Photography
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

            modelBuilder.Entity<User>().HasData(
               new User
               {
                   Id = 1,
                   FirstName = "Marika",
                   LastName = "Nowak-Piercer",
                   Username = "Marina",
                   Email = "email1@gmail.com",
                   EmailConfirmed = true,
                   City = "Krakow",
                   Gender = Gender.Kobieta,
                   Age = 18,
                   ImgSrc = "ProfilePhoto1",
                   RegistrationDate = DateTime.Now.AddHours(1),

               },
               new User
               {
                   Id = 2,
                   FirstName = "Jan",
                   LastName = "Kowalski-Piercer",
                   Username = "JanKo",
                   Email = "email2@gmail.com",
                   EmailConfirmed = true,
                   City = "Rzeszow",
                   Gender = Gender.Mężczyzna,
                   Age = 25,
                   ImgSrc = "ProfilePhoto12",
                   RegistrationDate = DateTime.Now.AddHours(2),
               },
               new User
               {
                   Id = 3,
                   FirstName = "Mirko",
                   LastName = "MirkoLastNamePiercer",
                   Username = "MirKO",
                   Email = "email3@gmail.com",
                   EmailConfirmed = true,
                   City = "Wroclaw",
                   Gender = Gender.Mężczyzna,
                   Age = 31,
                   ImgSrc = "ProfilePhoto3",
                   RegistrationDate = DateTime.Now.AddHours(3),
               },
               new User
               {
                   Id = 4,
                   FirstName = "Marko",
                   LastName = "Marko Marko Marko",
                   Username = "MarKO",
                   Email = "email4@gmail.com",
                   EmailConfirmed = true,
                   City = "Poznan",
                   Gender = Gender.Mężczyzna,
                   Age = 14,
                   ImgSrc = "ProfilePhoto4",
                   RegistrationDate = DateTime.Now.AddHours(5),
               },
               new User
               {
                   Id = 5,
                   FirstName = "SławoKO",
                   LastName = "sławko Sławko sławko",
                   Username = "SławKOR",
                   Email = "email5@gmail.com",
                   EmailConfirmed = true,
                   City = "Gliwice",
                   Gender = Gender.Mężczyzna,
                   Age = 17,
                   ImgSrc = "ProfilePhoto5",
                   RegistrationDate = DateTime.Now.AddHours(4),
               },
                new User
                {
                    Id = 6,
                    FirstName = "Sławomir",
                    LastName = "Słoneczny",
                    Username = "SławKOR",
                    Email = "slawek@slonce.com",
                    EmailConfirmed = true,
                    City = "Torun",
                    Gender = Gender.Mężczyzna,
                    Age = 21,
                    ImgSrc = "SrcSławekSłoneczny",
                    RegistrationDate = DateTime.Now,
                }
               );

            modelBuilder.Entity<Piercer>().HasData(
               new Piercer
               {
                   Id = 1,
                   UserId = 1,
                   Studio = "PierKRA",
                   About = "nastolenia piercerka sluzy przekuciami",
                   MediaFB = "FACEBOOK link 1",
                   MediaInstagram = "INSTAGRAM link 1",
                   MediaTwitter = "TWITTER link 1",
                   Punctures = Puncture.Przeklucie2,
                   Experience = Experience.Niewielkie
               },
               new Piercer
               {
                   Id = 2,
                   UserId = 2,
                   Studio = "PiercerRZ",
                   About = "bardzo duzo pracy - wciaz znajduje czas na pierscienie :)",
                   MediaFB = "FACEBOOK link 2",
                   MediaInstagram = "INSTAGRAM link 2",
                   MediaTwitter = "TWITTER link 2",
                   Punctures = Puncture.Przeklucie1,
                   Experience = Experience.Średnie
               },
               new Piercer
               {
                   Id = 3,
                   UserId = 3,
                   Studio = "PiercerRZ3",
                   About = "bardzo duzo pracy :)",
                   MediaFB = "FACEBOOK link e",
                   MediaInstagram = "INSTAGRAM link 3",
                   MediaTwitter = "TWITTER link 3",
                   Punctures = Puncture.Przeklucie3,
                   Experience = Experience.Duże
               }
               );

            modelBuilder.Entity<Tattooer>().HasData(
               new Tattooer
               {
                   Id = 1,
                   UserId = 4,
                   Experience = Experience.Niewielkie,
                   About = "Marko - sekacja o mnie",
                   MediaFB = "FACEBOOOK LINK 4",
                   MediaInstagram = "LINK INST 4",
                   MediaTwitter = "LINK TWITTER 4",
                   Studio = "STUDIO Poznan GO",
                   TattooStyle = TattooStyle.Styl1,
                   Technique = Technique.Handpoke
               },
               new Tattooer
               {
                   Id = 2,
                   UserId = 5,
                   Experience = Experience.Duże,
                   About = "SławKO- sekacja o mnie",
                   MediaFB = "FACEBOOOK LINK 5",
                   MediaInstagram = "LINK INST 5",
                   MediaTwitter = "LINK TWITTER 5",
                   Studio = "STUDIO = GLIWICE MAIN = STUDIO",
                   TattooStyle = TattooStyle.Styl3,
                   Technique = Technique.Maszynka
               }
               );

            modelBuilder.Entity<Model>().HasData(
               new Model
               {
                   Id = 1,
                   UserId = 1,
                   Experience = Experience.Duże,
                   Height = 160,
                   Weight = 53,
                   Breast = 60,
                   Waist = 45,
                   Hip = 70,
                   About = "cos tam robie cos tam nie robie - sekacja o mnie",
                   MediaFB = "",
                   MediaInstagram = "LINK INST 1",
                   MediaTwitter = "LINK TWITTER",
                   //BodyDecorations = new BodyDecorations {Puncture= false, Tattoo=true }
               },
               new Model
               {
                   Id = 2,
                   UserId = 2,
                   Experience = Experience.Niewielkie,
                   Height = 180,
                   Weight = 73,
                   Breast = 80,
                   Waist = 65,
                   Hip = 90,
                   About = "about about about about abour tasd",
                   MediaFB = "",
                   MediaInstagram = "LINK INST 2",
                   MediaTwitter = "LINK TWITTER 2",
                   //BodyDecorations = new BodyDecorations { Puncture = false, Tattoo = false }
               },
               new Model
               {
                   Id = 3,
                   UserId = 3,
                   Experience = Experience.Średnie,
                   Height = 170,
                   Weight = 63,
                   Breast = 70,
                   Waist = 55,
                   Hip = 60,
                   About = "kolejnny kolejny kolejny model model model about 3",
                   MediaFB = "",
                   MediaInstagram = "LINK INST 3",
                   MediaTwitter = "LINK TWITTER 3",
                   //BodyDecorations = new BodyDecorations { Puncture = true, Tattoo = false }
               }
               );

            modelBuilder.Entity<Photographer>().HasData(
               new Photographer
               {
                   Id = 1,
                   UserId = 4,
                   About = "Phothographer 1 about ",
                   MediaFB = "FACEBOOK 1 Photographer",
                   MediaInstagram = "INSTAGRAM 1 PHOTOGRAPHER",
                   MediaTwitter = "TWITTER 1 PHOTOGRAPHER",
                   Experience = Experience.Duże
               },
               new Photographer
               {
                   Id = 2,
                   UserId = 5,
                   About = "Phothographer 2 about ",
                   MediaFB = "FACEBOOK 2 Photographer",
                   MediaInstagram = "INSTAGRAM 2 PHOTOGRAPHER",
                   MediaTwitter = "TWITTER 2 PHOTOGRAPHER",
                   Experience = Experience.Niewielkie
               },
               new Photographer
               {
                   Id = 3,
                   UserId = 3,
                   About = "Phothographer 3 about ",
                   MediaFB = "FACEBOOK 3 Photographer",
                   MediaInstagram = "INSTAGRAM 3 PHOTOGRAPHER",
                   MediaTwitter = "TWITTER 3 PHOTOGRAPHER",
                   Experience = Experience.Średnie
               }
               );

            modelBuilder.Entity<Article>().HasData(
               new Article
               {
                   Id = 1,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy1-Title",
                   Content = "Rozmowy1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "sciezka IMG 1"
               },
               new Article
               {
                   Id = 2,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy2-Title",
                   Content = "Rozmowy2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "sciezka IMG 2"
               },
               new Article
               {
                   Id = 3,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy3e-Title",
                   Content = "Rozmowy3e_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "sciezka IMG 3"
               },
               new Article
               {
                   Id = 4,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy4-Title",
                   Content = "Rozmowy4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "sciezka IMG 4"
               },
               new Article
               {
                   Id = 5,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy5-Title",
                   Content = "Rozmowy5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "sciezka IMG 5"
               },
               new Article
               {
                   Id = 6,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia1-Title",
                   Content = "Wydarzenia1_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 1"
               },
               new Article
               {
                   Id = 7,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia2-Title",
                   Content = "Wydarzenia2_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 2"
               },
               new Article
               {
                   Id = 8,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia3-Title",
                   Content = "Wydarzenia3_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 3"
               },
               new Article
               {
                   Id = 9,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia4-Title",
                   Content = "Wydarzenia4_Content",
                   Date = DateTime.Now,
                   ImgSrc = "sciezka IMG 4"
               },
               new Article
               {
                   Id = 10,
                   UserId = 2,
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
                   UserId = 1,
                   TattooStyle = TattooStyle.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(12),
                   ImgSrc = "sciezka TATTOO 1"
               },
               new Tattoo
               {
                   Id = 2,
                   UserId = 2,
                   TattooStyle = TattooStyle.Styl2,
                   Color = Color.Czarny,
                   Technique = Technique.Maszynka,
                   Date = DateTime.Now.AddDays(13),
                   ImgSrc = "sciezka TATTOO 2"
               },
               new Tattoo
               {
                   Id = 3,
                   UserId = 3,
                   TattooStyle = TattooStyle.Styl3,
                   Color = Color.Kolorowy,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(14),
                   ImgSrc = "sciezka TATTOO 3"
               }
               );

            modelBuilder.Entity<Piercing>().HasData(
              new Piercing
              {
                  Id = 1,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "sciezka PIERCING 1",
                  Date = DateTime.Now.AddDays(1)
              },
              new Piercing
              {
                  Id = 2,
                  UserId = 2,
                  Puncture = Puncture.Przeklucie2,
                  ImgSrc = "sciezka PIERCING 2",
                  Date = DateTime.Now.AddDays(2)
              },
              new Piercing
              {
                  Id = 3,
                  UserId = 3,
                  Puncture = Puncture.Przeklucie3,
                  ImgSrc = "sciezka PIERCING 3",
                  Date = DateTime.Now.AddDays(3)
              }
              );


            modelBuilder.Entity<ModelPhoto>(b =>
            {
                b.HasData(
                  new ModelPhoto
                  {
                      Id = 1,
                      UserId = 1,
                      ModelingStyle = ModelingStyle.Akt,
                      ImgSrc = "sciezka MODEL 1",
                      Date = DateTime.Now.AddDays(33)
                  },
                  new ModelPhoto
                  {
                      Id = 2,
                      UserId = 2,
                      ModelingStyle = ModelingStyle.Edytorial,
                      ImgSrc = "sciezka MODEL 2",
                      Date = DateTime.Now.AddDays(34)
                  },
                  new ModelPhoto
                  {
                      Id = 3,
                      UserId = 3,
                      ModelingStyle = ModelingStyle.Fushion,
                      ImgSrc = "sciezka MODEL 3",
                      Date = DateTime.Now.AddDays(34)
                  });
                b.OwnsOne(e => e.BodyDecorations).HasData(new
                {
                    ModelPhotoId = 1,
                    Puncture = false,
                    Tattoo = false
                },
                new
                {
                    ModelPhotoId = 2,
                    Puncture = false,
                    Tattoo = true
                },
                new
                {
                    ModelPhotoId = 3,
                    Puncture = true,
                    Tattoo = false
                }
                );
            });

            modelBuilder.Entity<PhotographerPhoto>().HasData(
              new PhotographerPhoto
              {
                  Id = 1,
                  UserId = 1,
                  ModelingStyle = ModelingStyle.Akt,
                  ImgSrc = "sciezka Photographer 1",
                  Date = DateTime.Now.AddDays(11)
              },
              new PhotographerPhoto
              {
                  Id = 2,
                  UserId = 2,
                  ModelingStyle = ModelingStyle.Edytorial,
                  ImgSrc = "sciezka Photographer 2",
                  Date = DateTime.Now.AddDays(22)
              },
              new PhotographerPhoto
              {
                  Id = 3,
                  UserId = 3,
                  ModelingStyle = ModelingStyle.Fushion,
                  ImgSrc = "sciezka Photographer 3",
                  Date = DateTime.Now.AddDays(33)
              }
              );

            modelBuilder.Entity<AvailableDesign>().HasData(
                  new AvailableDesign
                  {
                      Id = 1,
                      UserId = 1,
                      TattooStyle = TattooStyle.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(1),
                      ImgSrc = "sciezka Available Design 1"
                  },
                  new AvailableDesign
                  {
                      Id = 2,
                      UserId = 2,
                      TattooStyle = TattooStyle.Styl2,
                      Color = Color.Kolorowy,
                      Technique = Technique.Maszynka,
                      Price = 300,
                      Reserved = true,
                      Date = DateTime.Now.AddDays(2),
                      ImgSrc = "sciezka Available Design 2"
                  },
                  new AvailableDesign
                  {
                      Id = 3,
                      UserId = 3,
                      TattooStyle = TattooStyle.Styl3,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
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

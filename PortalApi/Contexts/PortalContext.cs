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

        Random rnd = new Random();
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
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 2,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy2-Title",
                   Content = "Rozmowy2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 3,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy3e-Title",
                   Content = "Rozmowy3e_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 4,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy4-Title",
                   Content = "Rozmowy4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 5,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy5-Title",
                   Content = "Rozmowy5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 6,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy6-Title",
                   Content = "Rozmowy6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 7,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy7-Title",
                   Content = "Rozmowy7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 8,
                   UserId = 1,
                   ArticleSubcategoryId = 1,
                   Title = "Rozmowy8-Title",
                   Content = "Rozmowy8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 9,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia1-Title",
                   Content = "Wydarzenia1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 10,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia2-Title",
                   Content = "Wydarzenia2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 11,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia3-Title",
                   Content = "Wydarzenia3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 12,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia4-Title",
                   Content = "Wydarzenia4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 13,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia5-Title",
                   Content = "Wydarzenia5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 14,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia6-Title",
                   Content = "Wydarzenia6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 15,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia7-Title",
                   Content = "Wydarzenia7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 16,
                   UserId = 2,
                   ArticleSubcategoryId = 2,
                   Title = "Wydarzenia8-Title",
                   Content = "Wydarzenia8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 17,
                   UserId = 2,
                   ArticleSubcategoryId = 3,
                   Title = "Porady_o_tatuazu_1-Title",
                   Content = "Porady_o_tatuazu_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 18,
                   UserId = 2,
                   ArticleSubcategoryId = 3,
                   Title = "Porady_o_tatuazu_2-Title",
                   Content = "Porady_o_tatuazu_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 19,
                   UserId = 2,
                   ArticleSubcategoryId = 3,
                   Title = "Porady_o_tatuazu_3-Title",
                   Content = "Porady_o_tatuazu_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 20,
                   UserId = 2,
                   ArticleSubcategoryId = 3,
                   Title = "Porady_o_tatuazu_4-Title",
                   Content = "Porady_o_tatuazu_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 21,
                   UserId = 2,
                   ArticleSubcategoryId = 3,
                   Title = "Porady_o_tatuazu_5-Title",
                   Content = "Porady_o_tatuazu_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 22,
                   UserId = 2,
                   ArticleSubcategoryId = 3,
                   Title = "Porady_o_tatuazu_6-Title",
                   Content = "Porady_o_tatuazu_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 23,
                   UserId = 2,
                   ArticleSubcategoryId = 3,
                   Title = "Porady_o_tatuazu_7-Title",
                   Content = "Porady_o_tatuazu_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 24,
                   UserId = 2,
                   ArticleSubcategoryId = 3,
                   Title = "Porady_o_tatuazu_8-Title",
                   Content = "Porady_o_tatuazu_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 25,
                   UserId = 2,
                   ArticleSubcategoryId = 4,
                   Title = "Relacje_1-Title",
                   Content = "Relacje_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 26,
                   UserId = 2,
                   ArticleSubcategoryId = 4,
                   Title = "Relacje_2-Title",
                   Content = "Relacje_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 27,
                   UserId = 2,
                   ArticleSubcategoryId = 4,
                   Title = "Relacje_3-Title",
                   Content = "Relacje_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 28,
                   UserId = 2,
                   ArticleSubcategoryId = 4,
                   Title = "Relacje_4-Title",
                   Content = "Relacje_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 29,
                   UserId = 2,
                   ArticleSubcategoryId = 4,
                   Title = "Relacje_5-Title",
                   Content = "Relacje_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 30,
                   UserId = 2,
                   ArticleSubcategoryId = 4,
                   Title = "Relacje_6-Title",
                   Content = "Relacje_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 31,
                   UserId = 2,
                   ArticleSubcategoryId = 4,
                   Title = "Relacje_7-Title",
                   Content = "Relacje_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 32,
                   UserId = 2,
                   ArticleSubcategoryId = 4,
                   Title = "Relacje_8-Title",
                   Content = "Relacje_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 33,
                   UserId = 2,
                   ArticleSubcategoryId = 5,
                   Title = "Różne_1-Title",
                   Content = "Różne_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 34,
                   UserId = 2,
                   ArticleSubcategoryId = 5,
                   Title = "Różne_2-Title",
                   Content = "Różne_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 35,
                   UserId = 2,
                   ArticleSubcategoryId = 5,
                   Title = "Różne_3-Title",
                   Content = "Różne_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 36,
                   UserId = 2,
                   ArticleSubcategoryId = 5,
                   Title = "Różne_4-Title",
                   Content = "Różne_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 37,
                   UserId = 2,
                   ArticleSubcategoryId = 5,
                   Title = "Różne_5-Title",
                   Content = "Różne_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 38,
                   UserId = 2,
                   ArticleSubcategoryId = 5,
                   Title = "Różne_6-Title",
                   Content = "Różne_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 39,
                   UserId = 2,
                   ArticleSubcategoryId = 5,
                   Title = "Różne_7-Title",
                   Content = "Różne_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 40,
                   UserId = 2,
                   ArticleSubcategoryId = 5,
                   Title = "Różne_8-Title",
                   Content = "Różne_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 41,
                   UserId = 2,
                   ArticleSubcategoryId = 6,
                   Title = "Ze_świata_1-Title",
                   Content = "Ze_świata_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 42,
                   UserId = 2,
                   ArticleSubcategoryId = 6,
                   Title = "Ze_świata_2-Title",
                   Content = "Ze_świata_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 43,
                   UserId = 2,
                   ArticleSubcategoryId = 6,
                   Title = "Ze_świata_3-Title",
                   Content = "Ze_świata_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 44,
                   UserId = 2,
                   ArticleSubcategoryId = 6,
                   Title = "Ze_świata_4-Title",
                   Content = "Ze_świata_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 45,
                   UserId = 2,
                   ArticleSubcategoryId = 6,
                   Title = "Ze_świata_5-Title",
                   Content = "Ze_świata_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 46,
                   UserId = 2,
                   ArticleSubcategoryId = 6,
                   Title = "Ze_świata_6-Title",
                   Content = "Ze_świata_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 47,
                   UserId = 2,
                   ArticleSubcategoryId = 6,
                   Title = "Ze_świata_7-Title",
                   Content = "Ze_świata_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 48,
                   UserId = 2,
                   ArticleSubcategoryId = 6,
                   Title = "Ze_świata_8-Title",
                   Content = "Ze_świata_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 49,
                   UserId = 2,
                   ArticleSubcategoryId = 7,
                   Title = "Oferty_pracy_1-Title",
                   Content = "Oferty_pracy_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 50,
                   UserId = 2,
                   ArticleSubcategoryId = 7,
                   Title = "Oferty_pracy_2-Title",
                   Content = "Oferty_pracy_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 51,
                   UserId = 2,
                   ArticleSubcategoryId = 7,
                   Title = "Oferty_pracy_3-Title",
                   Content = "Oferty_pracy_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 52,
                   UserId = 2,
                   ArticleSubcategoryId = 7,
                   Title = "Oferty_pracy_4-Title",
                   Content = "Oferty_pracy_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 53,
                   UserId = 2,
                   ArticleSubcategoryId = 7,
                   Title = "Oferty_pracy_5-Title",
                   Content = "Oferty_pracy_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 54,
                   UserId = 2,
                   ArticleSubcategoryId = 7,
                   Title = "Oferty_pracy_6-Title",
                   Content = "Oferty_pracy_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 55,
                   UserId = 2,
                   ArticleSubcategoryId = 7,
                   Title = "Oferty_pracy_7-Title",
                   Content = "Oferty_pracy_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 56,
                   UserId = 2,
                   ArticleSubcategoryId = 7,
                   Title = "Oferty_pracy_8-Title",
                   Content = "Oferty_pracy_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 57,
                   UserId = 2,
                   ArticleSubcategoryId = 8,
                   Title = "O_przekłuciu_1-Title",
                   Content = "O_przekłuciu_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 58,
                   UserId = 2,
                   ArticleSubcategoryId = 8,
                   Title = "O_przekłuciu_2-Title",
                   Content = "O_przekłuciu_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 59,
                   UserId = 2,
                   ArticleSubcategoryId = 8,
                   Title = "O_przekłuciu_3-Title",
                   Content = "O_przekłuciu_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 60,
                   UserId = 2,
                   ArticleSubcategoryId = 8,
                   Title = "O_przekłuciu_4-Title",
                   Content = "O_przekłuciu_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 61,
                   UserId = 2,
                   ArticleSubcategoryId = 8,
                   Title = "O_przekłuciu_5-Title",
                   Content = "O_przekłuciu_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 62,
                   UserId = 2,
                   ArticleSubcategoryId = 8,
                   Title = "O_przekłuciu_6-Title",
                   Content = "O_przekłuciu_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 63,
                   UserId = 2,
                   ArticleSubcategoryId = 8,
                   Title = "O_przekłuciu_7-Title",
                   Content = "O_przekłuciu_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 64,
                   UserId = 2,
                   ArticleSubcategoryId = 8,
                   Title = "O_przekłuciu_8-Title",
                   Content = "O_przekłuciu_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 65,
                   UserId = 2,
                   ArticleSubcategoryId = 9,
                   Title = "Porady_1-Title",
                   Content = "Porady_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 66,
                   UserId = 2,
                   ArticleSubcategoryId = 9,
                   Title = "Porady_2-Title",
                   Content = "Porady_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 67,
                   UserId = 2,
                   ArticleSubcategoryId = 9,
                   Title = "Porady_3-Title",
                   Content = "Porady_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 68,
                   UserId = 2,
                   ArticleSubcategoryId = 9,
                   Title = "Porady_4-Title",
                   Content = "Porady_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 69,
                   UserId = 2,
                   ArticleSubcategoryId = 9,
                   Title = "Porady_5-Title",
                   Content = "Porady_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 70,
                   UserId = 2,
                   ArticleSubcategoryId = 9,
                   Title = "Porady_6-Title",
                   Content = "Porady_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 71,
                   UserId = 2,
                   ArticleSubcategoryId = 9,
                   Title = "Porady_7-Title",
                   Content = "Porady_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 72,
                   UserId = 2,
                   ArticleSubcategoryId = 9,
                   Title = "Porady_8-Title",
                   Content = "Porady_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 73,
                   UserId = 2,
                   ArticleSubcategoryId = 10,
                   Title = "Rozmowy_1-Title",
                   Content = "Rozmowy_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 74,
                   UserId = 2,
                   ArticleSubcategoryId = 10,
                   Title = "Rozmowy_2-Title",
                   Content = "Rozmowy_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 75,
                   UserId = 2,
                   ArticleSubcategoryId = 10,
                   Title = "Rozmowy_3-Title",
                   Content = "Rozmowy_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 76,
                   UserId = 2,
                   ArticleSubcategoryId = 10,
                   Title = "Rozmowy_4-Title",
                   Content = "Rozmowy_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 77,
                   UserId = 2,
                   ArticleSubcategoryId = 10,
                   Title = "Rozmowy_5-Title",
                   Content = "Rozmowy_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 78,
                   UserId = 2,
                   ArticleSubcategoryId = 10,
                   Title = "Rozmowy_6-Title",
                   Content = "Rozmowy_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 79,
                   UserId = 2,
                   ArticleSubcategoryId = 10,
                   Title = "Rozmowy_7-Title",
                   Content = "Rozmowy_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 80,
                   UserId = 2,
                   ArticleSubcategoryId = 10,
                   Title = "Rozmowy_8-Title",
                   Content = "Rozmowy_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 81,
                   UserId = 2,
                   ArticleSubcategoryId = 11,
                   Title = "Różne_1-Title",
                   Content = "Różne_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 82,
                   UserId = 2,
                   ArticleSubcategoryId = 11,
                   Title = "Różne_2-Title",
                   Content = "Różne_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 83,
                   UserId = 2,
                   ArticleSubcategoryId = 11,
                   Title = "Różne_3-Title",
                   Content = "Różne_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 84,
                   UserId = 2,
                   ArticleSubcategoryId = 11,
                   Title = "Różne_4-Title",
                   Content = "Różne_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 85,
                   UserId = 2,
                   ArticleSubcategoryId = 11,
                   Title = "Różne_5-Title",
                   Content = "Różne_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 86,
                   UserId = 2,
                   ArticleSubcategoryId = 11,
                   Title = "Różne_6-Title",
                   Content = "Różne_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 87,
                   UserId = 2,
                   ArticleSubcategoryId = 11,
                   Title = "Różne_7-Title",
                   Content = "Różne_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 88,
                   UserId = 2,
                   ArticleSubcategoryId = 11,
                   Title = "Różne_8-Title",
                   Content = "Różne_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 89,
                   UserId = 2,
                   ArticleSubcategoryId = 12,
                   Title = "Rozmowy_1-Title",
                   Content = "Rozmowy_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 90,
                   UserId = 2,
                   ArticleSubcategoryId = 12,
                   Title = "Rozmowy_2-Title",
                   Content = "Rozmowy_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 91,
                   UserId = 2,
                   ArticleSubcategoryId = 12,
                   Title = "Rozmowy_3-Title",
                   Content = "Rozmowy_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 92,
                   UserId = 2,
                   ArticleSubcategoryId = 12,
                   Title = "Rozmowy_4-Title",
                   Content = "Rozmowy_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 93,
                   UserId = 2,
                   ArticleSubcategoryId = 12,
                   Title = "Rozmowy_5-Title",
                   Content = "Rozmowy_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 94,
                   UserId = 2,
                   ArticleSubcategoryId = 12,
                   Title = "Rozmowy_6-Title",
                   Content = "Rozmowy_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 95,
                   UserId = 2,
                   ArticleSubcategoryId = 12,
                   Title = "Rozmowy_7-Title",
                   Content = "Rozmowy_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 96,
                   UserId = 2,
                   ArticleSubcategoryId = 12,
                   Title = "Rozmowy_8-Title",
                   Content = "Rozmowy_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 97,
                   UserId = 2,
                   ArticleSubcategoryId = 13,
                   Title = "Różne_1-Title",
                   Content = "Różne_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 98,
                   UserId = 2,
                   ArticleSubcategoryId = 13,
                   Title = "Różne_2-Title",
                   Content = "Różne_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 99,
                   UserId = 2,
                   ArticleSubcategoryId = 13,
                   Title = "Różne_3-Title",
                   Content = "Różne_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 100,
                   UserId = 2,
                   ArticleSubcategoryId = 13,
                   Title = "Różne_4-Title",
                   Content = "Różne_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 101,
                   UserId = 2,
                   ArticleSubcategoryId = 13,
                   Title = "Różne_5-Title",
                   Content = "Różne_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 102,
                   UserId = 2,
                   ArticleSubcategoryId = 13,
                   Title = "Różne_6-Title",
                   Content = "Różne_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 103,
                   UserId = 2,
                   ArticleSubcategoryId = 13,
                   Title = "Różne_7-Title",
                   Content = "Różne_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 104,
                   UserId = 2,
                   ArticleSubcategoryId = 13,
                   Title = "Różne_8-Title",
                   Content = "Różne_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 105,
                   UserId = 2,
                   ArticleSubcategoryId = 14,
                   Title = "Rozmowy_1-Title",
                   Content = "Rozmowy_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 106,
                   UserId = 2,
                   ArticleSubcategoryId = 14,
                   Title = "Rozmowy_2-Title",
                   Content = "Rozmowy_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 107,
                   UserId = 2,
                   ArticleSubcategoryId = 14,
                   Title = "Rozmowy_3-Title",
                   Content = "Rozmowy_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 108,
                   UserId = 2,
                   ArticleSubcategoryId = 14,
                   Title = "Rozmowy_4-Title",
                   Content = "Rozmowy_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 109,
                   UserId = 2,
                   ArticleSubcategoryId = 14,
                   Title = "Rozmowy_5-Title",
                   Content = "Rozmowy_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 110,
                   UserId = 2,
                   ArticleSubcategoryId = 14,
                   Title = "Rozmowy_6-Title",
                   Content = "Rozmowy_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 111,
                   UserId = 2,
                   ArticleSubcategoryId = 14,
                   Title = "Rozmowy_7-Title",
                   Content = "Rozmowy_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 112,
                   UserId = 2,
                   ArticleSubcategoryId = 14,
                   Title = "Rozmowy_8-Title",
                   Content = "Rozmowy_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 113,
                   UserId = 2,
                   ArticleSubcategoryId = 15,
                   Title = "Różne_1-Title",
                   Content = "Różne_1_Content",
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 114,
                   UserId = 2,
                   ArticleSubcategoryId = 15,
                   Title = "Różne_2-Title",
                   Content = "Różne_2_Content",
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 115,
                   UserId = 2,
                   ArticleSubcategoryId = 15,
                   Title = "Różne_3-Title",
                   Content = "Różne_3_Content",
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 116,
                   UserId = 2,
                   ArticleSubcategoryId = 15,
                   Title = "Różne_4-Title",
                   Content = "Różne_4_Content",
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 117,
                   UserId = 2,
                   ArticleSubcategoryId = 15,
                   Title = "Różne_5-Title",
                   Content = "Różne_5_Content",
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 118,
                   UserId = 2,
                   ArticleSubcategoryId = 15,
                   Title = "Różne_6-Title",
                   Content = "Różne_6_Content",
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 119,
                   UserId = 2,
                   ArticleSubcategoryId = 15,
                   Title = "Różne_7-Title",
                   Content = "Różne_7_Content",
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Article
               {
                   Id = 120,
                   UserId = 2,
                   ArticleSubcategoryId = 15,
                   Title = "Różne_8-Title",
                   Content = "Różne_8_Content",
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
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
                   Date = DateTime.Now.AddDays(1),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 2,
                   UserId = 2,
                   TattooStyle = TattooStyle.Styl2,
                   Color = Color.Czarny,
                   Technique = Technique.Maszynka,
                   Date = DateTime.Now.AddDays(2),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 3,
                   UserId = 3,
                   TattooStyle = TattooStyle.Styl3,
                   Color = Color.Kolorowy,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(3),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 4,
                   UserId = 1,
                   TattooStyle = TattooStyle.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(4),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 5,
                   UserId = 1,
                   TattooStyle = TattooStyle.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(5),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 6,
                   UserId = 1,
                   TattooStyle = TattooStyle.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(6),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 7,
                   UserId = 1,
                   TattooStyle = TattooStyle.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(7),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 8,
                   UserId = 1,
                   TattooStyle = TattooStyle.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(8),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 9,
                   UserId = 1,
                   TattooStyle = TattooStyle.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(9),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               },
               new Tattoo
               {
                   Id = 10,
                   UserId = 1,
                   TattooStyle = TattooStyle.Styl1,
                   Color = Color.Czarny,
                   Technique = Technique.Handpoke,
                   Date = DateTime.Now.AddDays(10),
                   ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
               }
               );

            modelBuilder.Entity<Piercing>().HasData(
              new Piercing
              {
                  Id = 1,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(1)
              },
              new Piercing
              {
                  Id = 2,
                  UserId = 2,
                  Puncture = Puncture.Przeklucie2,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(2)
              },
              new Piercing
              {
                  Id = 3,
                  UserId = 3,
                  Puncture = Puncture.Przeklucie3,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(3)
              },
              new Piercing
              {
                  Id = 4,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(4)
              },
              new Piercing
              {
                  Id = 5,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(5)
              },
              new Piercing
              {
                  Id = 6,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(6)
              },
              new Piercing
              {
                  Id = 7,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(7)
              },
              new Piercing
              {
                  Id = 8,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(8)
              },
              new Piercing
              {
                  Id = 9,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(9)
              },
              new Piercing
              {
                  Id = 10,
                  UserId = 1,
                  Puncture = Puncture.Przeklucie1,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(10)
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
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(1)
                  },
                  new ModelPhoto
                  {
                      Id = 2,
                      UserId = 2,
                      ModelingStyle = ModelingStyle.Edytorial,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(2)
                  },
                  new ModelPhoto
                  {
                      Id = 3,
                      UserId = 3,
                      ModelingStyle = ModelingStyle.Fushion,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(3)
                  },
                  new ModelPhoto
                  {
                      Id = 4,
                      UserId = 1,
                      ModelingStyle = ModelingStyle.Akt,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(4)
                  },
                  new ModelPhoto
                  {
                      Id = 5,
                      UserId = 1,
                      ModelingStyle = ModelingStyle.Akt,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(5)
                  },
                  new ModelPhoto
                  {
                      Id = 6,
                      UserId = 1,
                      ModelingStyle = ModelingStyle.Akt,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(6)
                  },
                  new ModelPhoto
                  {
                      Id = 7,
                      UserId = 1,
                      ModelingStyle = ModelingStyle.Akt,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(7)
                  },
                  new ModelPhoto
                  {
                      Id = 8,
                      UserId = 1,
                      ModelingStyle = ModelingStyle.Akt,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(8)
                  },
                  new ModelPhoto
                  {
                      Id = 9,
                      UserId = 1,
                      ModelingStyle = ModelingStyle.Akt,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(9)
                  },
                  new ModelPhoto
                  {
                      Id = 10,
                      UserId = 1,
                      ModelingStyle = ModelingStyle.Akt,
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                      Date = DateTime.Now.AddDays(10)
                  });
                b.OwnsOne(e => e.BodyDecorations).HasData(
                new
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
                },
                new
                {
                    ModelPhotoId = 4,
                    Puncture = true,
                    Tattoo = false
                },
                new
                {
                    ModelPhotoId = 5,
                    Puncture = true,
                    Tattoo = false
                },
                new
                {
                    ModelPhotoId = 6,
                    Puncture = true,
                    Tattoo = false
                },
                new
                {
                    ModelPhotoId = 7,
                    Puncture = true,
                    Tattoo = false
                },
                new
                {
                    ModelPhotoId = 8,
                    Puncture = true,
                    Tattoo = false
                },
                new
                {
                    ModelPhotoId = 9,
                    Puncture = true,
                    Tattoo = false
                },
                new
                {
                    ModelPhotoId = 10,
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
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(1)
              },
              new PhotographerPhoto
              {
                  Id = 2,
                  UserId = 2,
                  ModelingStyle = ModelingStyle.Edytorial,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(2)
              },
              new PhotographerPhoto
              {
                  Id = 3,
                  UserId = 3,
                  ModelingStyle = ModelingStyle.Fushion,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(3)
              },
              new PhotographerPhoto
              {
                  Id = 4,
                  UserId = 1,
                  ModelingStyle = ModelingStyle.Akt,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(4)
              },
              new PhotographerPhoto
              {
                  Id = 5,
                  UserId = 1,
                  ModelingStyle = ModelingStyle.Akt,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(5)
              },
              new PhotographerPhoto
              {
                  Id = 6,
                  UserId = 1,
                  ModelingStyle = ModelingStyle.Akt,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(6)
              },
              new PhotographerPhoto
              {
                  Id = 7,
                  UserId = 1,
                  ModelingStyle = ModelingStyle.Akt,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(7)
              },
              new PhotographerPhoto
              {
                  Id = 8,
                  UserId = 1,
                  ModelingStyle = ModelingStyle.Akt,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(8)
              },
              new PhotographerPhoto
              {
                  Id = 9,
                  UserId = 1,
                  ModelingStyle = ModelingStyle.Akt,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(9)
              },
              new PhotographerPhoto
              {
                  Id = 10,
                  UserId = 1,
                  ModelingStyle = ModelingStyle.Akt,
                  ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450),
                  Date = DateTime.Now.AddDays(10)
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
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
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
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
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
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
                  },
                  new AvailableDesign
                  {
                      Id = 4,
                      UserId = 1,
                      TattooStyle = TattooStyle.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(4),
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
                  },
                  new AvailableDesign
                  {
                      Id = 5,
                      UserId = 1,
                      TattooStyle = TattooStyle.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(5),
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
                  },
                  new AvailableDesign
                  {
                      Id = 6,
                      UserId = 1,
                      TattooStyle = TattooStyle.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(6),
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
                  },
                  new AvailableDesign
                  {
                      Id = 7,
                      UserId = 1,
                      TattooStyle = TattooStyle.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(7),
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
                  },
                  new AvailableDesign
                  {
                      Id = 8,
                      UserId = 1,
                      TattooStyle = TattooStyle.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(8),
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
                  },
                  new AvailableDesign
                  {
                      Id = 9,
                      UserId = 1,
                      TattooStyle = TattooStyle.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(9),
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
                  },
                  new AvailableDesign
                  {
                      Id = 10,
                      UserId = 1,
                      TattooStyle = TattooStyle.Styl1,
                      Color = Color.Kolorowy,
                      Technique = Technique.Handpoke,
                      Price = null,
                      Reserved = false,
                      Date = DateTime.Now.AddDays(10),
                      ImgSrc = "https://picsum.photos/" + rnd.Next(400, 450) + "/" + rnd.Next(400, 450)
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

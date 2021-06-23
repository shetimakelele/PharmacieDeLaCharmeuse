using Microsoft.EntityFrameworkCore;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data
{
   public  class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        #region Proprietes
        public DbSet<Models.Astuce> Astuces { get; set; }
        public DbSet<Models.ImageModel> ImageModels { get; set; }
        public DbSet<Models.TestProduit> TestProduits { get; set; }
        public DbSet<Models.CategorieProduit> CategorieProduits { get; set; }
        public DbSet<Models.Produit> Produits { get; set; }
        public DbSet<Models.ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Models.Commande> Commandes { get; set; }
        public DbSet<Models.CommandeDetail> CommandeDetails { get; set; }

        #endregion



        // methode permettant d'initialiser la base de données  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Categories produit
            modelBuilder.Entity<CategorieProduit>().HasData(
                    new CategorieProduit { CategorieProduitID = 1, NomCategorieProduit = "Médicament sans ordonnace", DescriptionCategorieProduit = "Médicament de premier niveau a recuper sans ordonance" }
                );
            modelBuilder.Entity<CategorieProduit>().HasData(
                    new CategorieProduit { CategorieProduitID = 2, NomCategorieProduit = "Médicament avec ordonnace", DescriptionCategorieProduit = "Médicament de deuxieme niveau uniquement par ordonnance" }
                );

            // produit
            modelBuilder.Entity<Produit>().HasData(
                    new Produit
                    {
                        ProduitId = 1,
                        Nom = "Doliprane",
                        DescriptionCourte = "Ici une Description courte",
                        DescriptionLongue = "ici une DescriptionLongue longue",
                        Prix = 2,
                        PrixPromo = 1,
                        EnStock = 10,
                        ProduitDuMois = true,
                        ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                        CategorieProduitId = 1

                    }
                );

             modelBuilder.Entity<Produit>().HasData(
                    new Produit
                    {
                        ProduitId = 2,
                        Nom = "Paracetamol",
                        DescriptionCourte = "Ici une Description courte",
                        DescriptionLongue = "ici une DescriptionLongue longue",
                        Prix = 5,
                        PrixPromo = 1,
                        EnStock = 100,
                        ProduitDuMois = true,
                        ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                        CategorieProduitId = 1

                    }
               );

            modelBuilder.Entity<Produit>().HasData(
                    new Produit
                    {
                        ProduitId = 4,
                        Nom = "Doliprane",
                        DescriptionCourte = "Ici une Description courte",
                        DescriptionLongue = "ici une DescriptionLongue longue",
                        Prix = 2,
                        PrixPromo = 1,
                        EnStock = 10,
                        ProduitDuMois = true,
                        ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                        CategorieProduitId = 2

                    }
                );

             modelBuilder.Entity<Produit>().HasData(
                    new Produit
                    {
                        ProduitId = 5,
                        Nom = "Sirop",
                        DescriptionCourte = "Ici une Description courte",
                        DescriptionLongue = "ici une DescriptionLongue longue",
                        Prix = 5,
                        PrixPromo = 1,
                        EnStock = 105,
                        ProduitDuMois = false,
                        ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                        CategorieProduitId = 2

                    }
                );


            modelBuilder.Entity<Produit>().HasData(
                   new Produit
                   {
                       ProduitId = 6,
                       Nom = "Baume",
                       DescriptionCourte = "Ici une Description courte",
                       DescriptionLongue = "ici une DescriptionLongue longue",
                       Prix = 15,
                       PrixPromo = 16,
                       EnStock = 105,
                       ProduitDuMois = false,
                       ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                       CategorieProduitId = 2

                   }
               );
            modelBuilder.Entity<Produit>().HasData(
                   new Produit
                   {
                       ProduitId = 3,
                       Nom = "contraception",
                       DescriptionCourte = "Ici une Description courte",
                       DescriptionLongue = "ici une DescriptionLongue longue",
                       Prix = 15,
                       PrixPromo = 16,
                       EnStock = 105,
                       ProduitDuMois = false,
                       ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                       CategorieProduitId = 2

                   }
               );

            modelBuilder.Entity<Produit>().HasData(
                   new Produit
                   {
                       ProduitId = 7,
                       Nom = "Lotion",
                       DescriptionCourte = "Ici une Description courte",
                       DescriptionLongue = "ici une DescriptionLongue longue",
                       Prix = 15,
                       PrixPromo = 16,
                       EnStock = 105,
                       ProduitDuMois = false,
                       ImageUrL = "https://www.dinafem.org/uploads/sativex_3.jpg",
                       CategorieProduitId = 2

                   }
               );
            modelBuilder.Entity<Produit>().HasData(
                   new Produit
                   {
                       ProduitId = 8,
                       Nom = "dentifrice",
                       DescriptionCourte = "Ici une Description courte",
                       DescriptionLongue = "ici une DescriptionLongue longue",
                       Prix = 15,
                       PrixPromo = 16,
                       EnStock = 105,
                       ProduitDuMois = true,
                       ImageUrL = "https://www.dinafem.org/uploads/sativex_3.jpg",
                       CategorieProduitId = 2

                   }
               );



            //Astuce
            modelBuilder.Entity<Astuce>().HasData(
                   new Astuce
                   {
                       AstuceId = 1,
                       Titre = "ici un titre",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",                     
                       ProduitId = 4,
                   }
               );

            modelBuilder.Entity<Astuce>().HasData(
                   new Astuce
                   {
                       AstuceId = 2,
                       Titre = "ici un titre",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",                      
                       ProduitId = 4,
                   }
               );


            modelBuilder.Entity<Astuce>().HasData(
                   new Astuce
                   {
                       AstuceId = 3,
                       Titre = "ici un titre",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",             
                       ProduitId = 4,
                   }
               );

            modelBuilder.Entity<Astuce>().HasData(
                   new Astuce
                   {
                       AstuceId = 4,
                       Titre = "ici un titre",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",
                       ProduitId = 4,
                   }
               );

            modelBuilder.Entity<Astuce>().HasData(
                   new Astuce
                   {
                       AstuceId = 5,
                       Titre = "ici un titre",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",        
                       ProduitId = 4,
                   }
               );


            modelBuilder.Entity<Astuce>().HasData(
                   new Astuce
                   {
                       AstuceId = 6,
                       Titre = "ici un titre",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",
                       ProduitId = 4,
                   }
               );

            // Test
            modelBuilder.Entity<TestProduit>().HasData(
                   new TestProduit
                   {
                       TestProduitId =1,
                       Titre = "dentifrice",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       NoteTest = 8,
                       TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",
             

                   }
               );


            modelBuilder.Entity<TestProduit>().HasData(
                   new TestProduit
                   {
                       TestProduitId = 2,
                       Titre = "Savon ph 7",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       NoteTest = 6,
                       TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",


                   }
               );

            modelBuilder.Entity<TestProduit>().HasData(
                   new TestProduit
                   {
                       TestProduitId = 3,
                       Titre = "dentifrice",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       NoteTest = 1,
                       TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",


                   }
               );

            modelBuilder.Entity<TestProduit>().HasData(
                   new TestProduit
                   {
                       TestProduitId = 4,
                       Titre = "dentifrice",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       NoteTest = 1,
                       TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",


                   }
               );

            modelBuilder.Entity<TestProduit>().HasData(
                   new TestProduit
                   {
                       TestProduitId = 5,
                       Titre = "dentifrice",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       NoteTest = 5,
                       TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",


                   }
               );

            modelBuilder.Entity<TestProduit>().HasData(
                   new TestProduit
                   {
                       TestProduitId = 6,
                       Titre = "dentifrice",
                       DescriptionCourte = "Ici une Description courte",
                       Description = "ici une DescriptionLongue longue",
                       NoteTest = 3,
                       TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",


                   }
               );
        }
    }
    
}

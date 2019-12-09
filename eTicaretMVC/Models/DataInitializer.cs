using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eTicaretMVC.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
         protected override void Seed(DataContext context)
        {
          
             var categories=new List<Category>()
            {
                new Category(){Name = "Telefon/Telefon Aksesuarları",Description = "Telefon Ürünleri"},
                new Category(){Name = "Bilgisayar/Tablet",Description = "Bilgisayar Ürünleri"},
                new Category(){Name = "Beyaz Eşya",Description = "Beyaz Eşya Ürünleri"},
                new Category(){Name = "Foto&Kamera",Description = "Kamera Ürünleri"},
                new Category(){Name = "Klima&Isıtıcılar",Description = "Klima Ürünleri"},
            };
            foreach (var i in categories)
            {
                context.Categories.Add(i);
            }
            context.SaveChanges();



            var products = new List<Product>()
            {
                new Product(){Name = "iPhone11",Description = "Fusce vel sapien elit in malesuada semper miFusce vel sapien elit in malesuada semper miFusce vel sapien elit in malesuada semper miFusce vel sapien elit in malesuada semper mi.",Price =1000,Stock =200 ,IsApproved =true,CategoryId =1 ,IsHome = true,Image = "1.jpg"},
                new Product(){Name = "iPhoneX",Description = "Fusce vel sapien elit in malesuada semper mi.",Price =800,Stock =100 ,IsApproved =false,CategoryId =1,IsHome = true,Image = "2.jpg" },
                new Product(){Name = "Macbook",Description = "Fusce vel sapien elit in malesuada semper mi.",Price =3000,Stock =50 ,IsApproved =true,CategoryId =2 ,Image = "3.jpg"},
                new Product(){Name = "Monster",Description = "Fusce vel sapien elit in malesuada semper mi.",Price =1500,Stock =20 ,IsApproved =false,CategoryId =2 ,Image = "4.png"},
                new Product(){Name = "Arçelik 574560 EB A++ 560 Lt Çift Kapılı Buzdolabı ",Description = "Fusce vel sapien elit in malesuada semper mi.",Price =100,Stock =200 ,IsApproved =true,CategoryId =3,IsHome = true,Image = "5.png" },
                new Product(){Name = "LG 43UM7300PUA Alexa Built-in 43 4K Ultra HD Smart LED TV",Description = "Fusce vel sapien elit in malesuada semper mi.",Price =1000,Stock =250 ,IsApproved =true,CategoryId =3 ,Image = "6.jpg"},
                new Product(){Name = "Canon EOS 4000D + 18-55mm Lens Dijital SLR Fotoğraf Makinesi",Description = "Fusce vel sapien elit in malesuada semper mi.",Price =1000,Stock =25 ,IsApproved =true,CategoryId =4,IsHome = true ,Image = "7.jpg"},
               
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
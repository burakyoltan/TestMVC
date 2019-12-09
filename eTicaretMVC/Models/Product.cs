using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace eTicaretMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Adı")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fiyatı")]
        public double Price { get; set; }
        [DisplayName("Stok")]
        public int Stock { get; set; }
        public string Image { get; set; }
        [DisplayName("Onaylı mı?")]
        public bool IsApproved { get; set; }
        [DisplayName("Anasayfada mı?")]
        public bool IsHome{ get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
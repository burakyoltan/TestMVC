using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static System.ComponentModel.DataAnnotations.ValidationAttribute;

namespace eTicaretMVC.Models
{
    public class Category
    {
        public int Id { get; set; }



        [DisplayName("Kategori Adı")]
        [StringLength(30, ErrorMessage = "3-20 karakter uzunluğunda olmalıdır", MinimumLength = 3)]

        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
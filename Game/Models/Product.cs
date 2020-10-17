using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString="{0:c}")]
        //0 represents the value to be formatted by 'c' which displays the currency
        [Range(0.00,99999)]
        public double Price { get; set; }

        [Display(Name="Category")]
        public int CategoryId { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        //reference the parent class(1 category many products)

       public Category Category { get; set; }

























    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models {

    /// <summary>
    /// The product class for EF
    /// by Glenn Lindmark
    /// August 20, 2019
    /// </summary>

    public class Product {

        [Key]

        public int ProductId { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }

        public decimal Price { get; set; }
        [MaxLength(8)]
        public int Qty { get; set; }

        public string Status { get; set; }

    }
}

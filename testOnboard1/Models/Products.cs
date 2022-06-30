using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testOnboard1.Models
{
    public class Products
    {
        [Key]
        public int ProductsId { get; set; }
        public string ProductsName { get; set; }
        public int ProductPrice { get; set; }
    }
}

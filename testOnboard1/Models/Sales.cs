using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testOnboard1.Models
{
    public class Sales
    {
        [Key]
        public int SalesId { get; set; }
        public string Customer { get; set; }
        public string Store { get; set; }
        public string Product { get; set; }
        public string DateSold { get; set; }


    }
}

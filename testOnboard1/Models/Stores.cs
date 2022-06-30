using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testOnboard1.Models
{
    public class Stores
    {
        [Key]
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }

    }
}

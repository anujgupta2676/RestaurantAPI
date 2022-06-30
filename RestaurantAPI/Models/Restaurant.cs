using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string RestaurantName { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagerAPI.Models
{
    public class FoodItems
    {
        [Key]
        public int FoodID { get; set; }

        [Column(TypeName = "nvarchar(100)")] // permet de definir le type de string  vers  varchar
        public string FoodName { get; set; }

        public decimal FoodPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagerAPI.Models
{
    public class Customers: Entity
    {
        [Key] //permet de definir cet attribut comme cle
        public int CustomerID { get; set; }

        [Column(TypeName = "nvarchar(100)")] // permet de definir le type de string  vers  varchar
        public string CustomerName { get; set; }


    }
}

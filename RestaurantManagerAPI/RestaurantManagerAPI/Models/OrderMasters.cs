using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagerAPI.Models
{
    public class OrderMasters
    {
        [Key]
        public int OrderMasterID { get; set; }

        [Column(TypeName = "nvarchar(50)")] // permet de definir le type de string  vers  varchar
        public string OrderNumber { get; set; } // Id de la commande qui sera visible par le client

        public int CustomerID { get; set; }  // Id du client qui fait la commande
        public Customers Customer { get; set; } // (clee) pour definir la clee etrangere customerId

        [Column(TypeName = "nvarchar(20)")] // permet de definir le type de string  vers  varchar
        public string PaymentMethod { get; set; }

        public decimal TotalPrice { get; set; }

        public List<OrdersItems> OrderItemList {get; set;} // liste de clee etrangere  definissant les OrderItems
    }
}

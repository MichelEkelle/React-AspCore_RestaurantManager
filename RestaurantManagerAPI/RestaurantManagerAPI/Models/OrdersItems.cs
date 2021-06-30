using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagerAPI.Models
{
    public class OrdersItems: Entity
    {
        [Key]
        public int OrderItemID { get; set; }
        public int FoodItemID { get; set; } // ID  repas selectionné
        public FoodItems FoodItem { get; set; } // clee etrangere fooditem
        public int OrderMasterID { get; set; } // ID de la commande general sur laquelle sera ajout/ cette Item de commande
       // public OrderMasters OrderMaster { get; set; } // clee etrangere
        public decimal FoodItemPrice { get; set; } // prix du repas selectionné/ ceci pour sauvegarder le rpux du plat qui doit etre appliquer au
                                                   // moment de l'achat
        public int Quantity { get; set; } // Nombre de plat  du repas selectionné

    }
}

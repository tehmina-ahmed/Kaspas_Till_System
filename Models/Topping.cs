using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaspasApp.Models
{
    public class Topping
    {
        public int ID { get; set; }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
      
        public string PictureURL { get; set; }
        public virtual Product Product { get; set; }
        //public virtual Toppings Topping { get; set; }
        public DateTime CreatedAt { get; set; }

        //public virtual List<Products> Product { get; set; }

    }
}

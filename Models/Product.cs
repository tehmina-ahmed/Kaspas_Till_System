using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaspasApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureURL { get; set; }

        public int Price { get; set; }

        public DateTime CreatedAt { get; set; }

        
        public virtual List<Topping> Topping { get; set; }

    }
}

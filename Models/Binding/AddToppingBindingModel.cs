using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaspasApp.Models.Binding
{
    public class AddToppingBindingModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureURL { get; set; }
        public int ProductID { get; set; }
        public string Price { get; set; }

        public virtual Product Product { get; set; }
    }
}

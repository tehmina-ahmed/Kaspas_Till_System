using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaspasApp.Models.Binding
{
    public class UpdateProductBindingModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureURL { get; set; }

        public int Price { get; set; }
    }
}

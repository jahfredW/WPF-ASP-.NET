using gestion_de_stocks.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stocks.Models.Dtos
{
    public class TypesproduitDtoOut
    {
        public int IdTypesProduits { get; set; }

        public string? LibelleTypeProduit { get; set; }

        //public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
    }

    public class TypesproduitDtoIn
    {
        public string? LibelleTypeProduit { get; set; }

        // public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}

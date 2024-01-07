using gestion_de_stocks.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace gestion_de_stocks.Models.Dtos
{
    public class CategoryDtoOut
    {
        public int IdCategories { get; set; }

        public string? LibelleCategorie { get; set; }

        public int IdTypesProduits { get; set; }

        //public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
        public string LeTypeProduit { get; set; } = null!;
    }

    public class CategoryDtoIn
    {
        public string? LibelleCategorie { get; set; }

        public int IdTypesProduits { get; set; }

        //public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
        public int LeTypeProduit { get; set; }
    }
}

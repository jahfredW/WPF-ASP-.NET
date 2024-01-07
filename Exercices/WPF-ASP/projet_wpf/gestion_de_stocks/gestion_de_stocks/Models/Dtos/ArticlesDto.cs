using gestion_de_stocks.Models.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stocks.Models.Dtos
{
    public class ArticleDtoOut 
    {
        public int IdArticles { get; set; }

        public string? LibelleArticle { get; set; }

        public int? QuantiteStockee { get; set; }

        public int IdCategories { get; set; }

        public string LaCategorie { get; set; } = null!;

       
    }

    public class ArticleDtoIn 
    {
        public string? LibelleArticle { get; set; }

        public int? QuantiteStockee { get; set; }

        public int IdCategories { get; set; }

        
    }
}

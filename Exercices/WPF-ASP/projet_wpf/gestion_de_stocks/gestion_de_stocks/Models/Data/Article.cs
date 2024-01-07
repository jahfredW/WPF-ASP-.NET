using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace gestion_de_stocks.Models.Data;

public partial class Article 
{
    public int IdArticles { get; set; }

    public string? LibelleArticle { get; set; }

    public int? QuantiteStockee { get; set; }

    public int IdCategories { get; set; }

    public virtual Category LaCategorie { get; set; } = null!;

    
}

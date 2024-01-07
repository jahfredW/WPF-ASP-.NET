using System;
using System.Collections.Generic;

namespace gestion_de_stocks.Models.Data;

public partial class Category
{
    public int IdCategories { get; set; }

    public string? LibelleCategorie { get; set; }

    public int IdTypesProduits { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    public virtual Typesproduit LeTypeProduit { get; set; } = null!;
}

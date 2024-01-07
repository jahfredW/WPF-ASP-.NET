using System;
using System.Collections.Generic;

namespace gestion_de_stocks.Models.Data;

public partial class Typesproduit
{
    public int IdTypesProduits { get; set; }

    public string? LibelleTypeProduit { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}

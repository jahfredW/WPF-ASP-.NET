using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using gestion_de_stocks.Models.Data;

namespace gestion_de_stocks.Models.Services;

public class TypesproduitsService
{
    private readonly stockContext _context;

    public TypesproduitsService(stockContext context)
    {
        _context = context;
    }

    public void AddTypesproduit(Typesproduit entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _context.Typesproduits.Add(entity);
        _context.SaveChanges();
    }

    public IEnumerable<Typesproduit> GetAllTypesproduits()
    {
        return _context.Typesproduits.ToList();
    }

    public Typesproduit GetTypesproduitById(int id)
    {
        Typesproduit entity = _context.Typesproduits.FirstOrDefault(entity => entity.IdTypesProduits == id);

        return entity;
    }
    public void DeleteTypesproduit(Typesproduit entity)
    {

        _context.Typesproduits.Remove(entity);
        _context.SaveChanges();
    }

    public void UpdateTypesproduit(Typesproduit entity)
    {
        _context.Typesproduits.Update(entity);
        _context.SaveChanges();
    }

}


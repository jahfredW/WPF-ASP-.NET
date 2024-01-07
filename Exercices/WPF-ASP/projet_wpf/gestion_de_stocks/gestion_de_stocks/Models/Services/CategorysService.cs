using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using gestion_de_stocks.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace gestion_de_stocks.Models.Services;

public class CategoriesService
{
    private readonly stockContext _context;

    public CategoriesService(stockContext context)
    {
        _context = context;
    }

    public void AddCategorie(Category entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _context.Categories.Add(entity);
        _context.SaveChanges();
    }

    public IEnumerable<Category> GetAllCategories()
    {
        return _context.Categories.Include("LeTypeProduit").ToList();
    }

    public Category GetCategorieById(int id)
    {
        Category entity = _context.Categories.Include("LeTypeProduit").FirstOrDefault(entity => entity.IdCategories == id);

        return entity;
    }

    public Category GetCategorieByName(string name)
    {
        Category entity = _context.Categories.Include("LeTypeProduit").FirstOrDefault(entity => entity.LibelleCategorie == name);

        return entity;
    }
    public void DeleteCategorie(Category entity)
    {

        _context.Categories.Remove(entity);
        _context.SaveChanges();
    }

    public void UpdateCategorie(Category entity)
    {
        _context.Categories.Update(entity);
        _context.SaveChanges();
    }

}



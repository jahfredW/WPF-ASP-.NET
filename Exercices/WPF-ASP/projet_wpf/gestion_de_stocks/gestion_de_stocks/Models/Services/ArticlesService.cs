using gestion_de_stocks.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gestion_de_stocks.Models.Services;

public class ArticlesService
{
    private readonly stockContext _context;

    public ArticlesService(stockContext context)
    {
        _context = context;
    }

    public void AddArticle(Article entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _context.Articles.Add(entity);
        _context.SaveChanges();
    }

    public IEnumerable<Article> GetAllArticles()
    {
        return _context.Articles.Include("LaCategorie").ToList();
    }

    public Article GetArticleById(int id)
    {
        Article entity = _context.Articles.Include("LaCategorie").FirstOrDefault(entity => entity.IdArticles == id);

        return entity;
    }
    public void DeleteArticle(Article entity)
    {

        _context.Articles.Remove(entity);
        _context.SaveChanges();
    }

    public void UpdateArticle(Article entity)
    {
        _context.Articles.Update(entity);
        _context.SaveChanges();
    }

}



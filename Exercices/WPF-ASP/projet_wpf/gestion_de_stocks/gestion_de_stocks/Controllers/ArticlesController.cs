using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using gestion_de_stocks.Models.Services;
using gestion_de_stocks.Models.Data;
using gestion_de_stocks.Models;
using gestion_de_stocks.Models.Profiles;
using gestion_de_stocks.Models.Dtos;
using System.Collections.ObjectModel;

namespace gestion_de_stocks.Controllers;


public class ArticlesController : ControllerBase
{
    private readonly ArticlesService _ArticlesService;
    private readonly IMapper _mapper;

    public ArticlesController(stockContext context)
    {
        // on passe le contexte au controller, pour le donner ensuite au service. 
        // obligé de créer une configuration de mapping de la sorte. 
        _ArticlesService = new ArticlesService(context);
        
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<ArticlesProfile>();
        });
        _mapper = config.CreateMapper();
    }


    public ObservableCollection<ArticleDtoOut> GetAllArticles()
    {
        IEnumerable<Article> listeArticles = _ArticlesService.GetAllArticles();
        _mapper.Dump();
        return _mapper.Map<ObservableCollection<ArticleDtoOut>>(listeArticles);
    }

    public ArticleDtoOut? GetArticleById(int id)
    {
        var ArticleItem = _ArticlesService.GetArticleById(id);

        if (ArticleItem != null)
        {
            return _mapper.Map<ArticleDtoOut>(ArticleItem);
        }

        return null;
    }

    
    public void CreateArticle(ArticleDtoIn entity)
    {
        Article newArticle = _mapper.Map<Article>(entity);
        _ArticlesService.AddArticle(newArticle);
    }

   
    public void UpdateArticle(int id, ArticleDtoIn entity)
    {
        var ArticleFromRepo = _ArticlesService.GetArticleById(id);
        
        _mapper.Map(entity, ArticleFromRepo);
        _ArticlesService.UpdateArticle(ArticleFromRepo);
       
    }

    public void DeleteArticle(int id)
    {
        var ArticleFromRepo = _ArticlesService.GetArticleById(id);
        if (ArticleFromRepo != null)
        {
            _ArticlesService.DeleteArticle(ArticleFromRepo);
        }
    }

    
    public ActionResult PartialArticleUpdate(int id, [FromBody] JsonPatchDocument<Article> patchDoc)
    {
        var ArticleFromRepo = _ArticlesService.GetArticleById(id);

        if (ArticleFromRepo == null)
        {
            return NotFound();
        }

        var ArticleToPatch = _mapper.Map<Article>(ArticleFromRepo);

        patchDoc.ApplyTo(ArticleToPatch, ModelState);
        if (!TryValidateModel(ArticleToPatch))
        {
            return ValidationProblem();
        }

        _mapper.Map(ArticleToPatch, ArticleFromRepo);
        _ArticlesService.UpdateArticle(ArticleFromRepo);

        return NoContent();
    }
}


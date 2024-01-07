using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using gestion_de_stocks.Models.Services;
using gestion_de_stocks.Models.Dtos;
using gestion_de_stocks.Models.Data;
using gestion_de_stocks.Models.Profiles;
using gestion_de_stocks.Models;

namespace gestion_de_stocks.Controllers;


public class CategoriesController : ControllerBase
{
    private readonly CategoriesService _categoriesService;
    private readonly IMapper _mapper;

    public CategoriesController(stockContext context)
    {
        _categoriesService = new CategoriesService(context);
       
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<CategoriesProfile>();
        });
        _mapper = config.CreateMapper();
    }

 
    public IEnumerable<CategoryDtoOut> GetAllCategories()
    {
        var listeCategories = _categoriesService.GetAllCategories();
        return _mapper.Map<IEnumerable<CategoryDtoOut>>(listeCategories);
    }

    public Category GetCategoryByName(string categoryName)
    {
        Category category = _categoriesService.GetCategorieByName(categoryName);

        return category;
    }

    //[HttpGet("{id}", Name = "GetCategorieById")]
    //public ActionResult<CategoriesDTO> GetCategorieById(int id)
    //{
    //    var CategorieItem = _CategoriesService.GetCategorieById(id);

    //    if (CategorieItem != null)
    //    {
    //        return Ok(_mapper.Map<CategoriesDTO>(CategorieItem));
    //    }

    //    return NotFound();
    //}

    //[HttpPost]
    //public ActionResult<CategoriesDTO> CreateCategorie(Categorie entity)
    //{
    //    _CategoriesService.AddCategorie(entity);
    //    return CreatedAtRoute(nameof(GetCategorieById), new { Id = entity.IdCategorie }, entity);
    //}

    //[HttpPut("{id}")]
    //public ActionResult UpdateCategorie(int id, CategoriesDTO entity)
    //{
    //    var CategorieFromRepo = _CategoriesService.GetCategorieById(id);
    //    if (CategorieFromRepo == null)
    //    {
    //        return NotFound();
    //    }

    //    _mapper.Map(entity, CategorieFromRepo);
    //    _CategoriesService.UpdateCategorie(CategorieFromRepo);
    //    return NoContent();
    //}

    //[HttpPatch("{id}")]
    //public ActionResult PartialCategorieUpdate(int id, [FromBody] JsonPatchDocument<Categorie> patchDoc)
    //{
    //    var CategorieFromRepo = _CategoriesService.GetCategorieById(id);

    //    if (CategorieFromRepo == null)
    //    {
    //        return NotFound();
    //    }

    //    var CategorieToPatch = _mapper.Map<Categorie>(CategorieFromRepo);

    //    patchDoc.ApplyTo(CategorieToPatch, ModelState);
    //    if (!TryValidateModel(CategorieToPatch))
    //    {
    //        return ValidationProblem();
    //    }

    //    _mapper.Map(CategorieToPatch, CategorieFromRepo);
    //    _CategoriesService.UpdateCategorie(CategorieFromRepo);

    //    return NoContent();
    //}
}


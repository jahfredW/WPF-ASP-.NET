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
using gestion_de_stocks.Models;
using gestion_de_stocks.Models.Profiles;

namespace gestion_de_stocks.Controllers;


public class TypesproduitsController : ControllerBase
{
    private readonly TypesproduitsService _typesproduitsService;
    private readonly IMapper _mapper;

    public TypesproduitsController(stockContext context)
    {
        _typesproduitsService = new TypesproduitsService(context);
    
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<typesproduitProfile>();
        });
        _mapper = config.CreateMapper();
    }

 
    public IEnumerable<TypesproduitDtoOut> GetAllTypesproduits()
    {
        var listeTypesproduits = _typesproduitsService.GetAllTypesproduits();
        return _mapper.Map<IEnumerable<TypesproduitDtoOut>>(listeTypesproduits);
    }

     
}


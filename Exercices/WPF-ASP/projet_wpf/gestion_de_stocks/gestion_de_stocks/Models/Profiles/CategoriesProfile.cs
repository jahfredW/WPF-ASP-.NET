using AutoMapper;
using gestion_de_stocks.Models.Data;
using gestion_de_stocks.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stocks.Models.Profiles
{
    public class CategoriesProfile : Profile
    {
        public CategoriesProfile()
        {
            CreateMap<Category, CategoryDtoOut>().ForMember(dest => dest.LeTypeProduit, opt => opt.MapFrom(src => src.LeTypeProduit.LibelleTypeProduit));
            //CreateMap<CategoryDtoIn, Category>().ForMember(dest => dest.LeTypeProduit.IdTypesProduits, opt => opt.MapFrom(src => src.IdTypesProduits));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using gestion_de_stocks.Models.Data;
using gestion_de_stocks.Models.Dtos;
using Org.BouncyCastle.Tls;

namespace gestion_de_stocks.Models.Profiles
{
    public class ArticlesProfile : Profile
    {
        public ArticlesProfile()
        {
            CreateMap<ArticleDtoIn, Article>();
            CreateMap<Article, ArticleDtoOut>().ForMember(dest => dest.LaCategorie, opt => opt.MapFrom(src => src.LaCategorie.LibelleCategorie));
            CreateMap<ArticleDtoOut, Article>().ForMember(dest => dest.LaCategorie, opt => opt.MapFrom(src => new Category { LibelleCategorie = src.LaCategorie }));
            
        }
        
    }
}

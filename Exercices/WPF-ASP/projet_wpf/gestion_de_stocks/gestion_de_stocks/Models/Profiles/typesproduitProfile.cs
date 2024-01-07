using AutoMapper;
using gestion_de_stocks.Models.Data;
using gestion_de_stocks.Models.Dtos;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stocks.Models.Profiles
{
    public class typesproduitProfile : Profile
    {
        public typesproduitProfile() 
        {
            CreateMap<TypesproduitDtoIn, Typesproduit>();
            CreateMap<Typesproduit, TypesproduitDtoOut>();
        }

    }
}

using AutoMapper;
using FaturaTahsilat.API.DTOs;
using FaturaTahsilat.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Abone, AboneDto>();
            CreateMap<AboneDto, Abone>();
            CreateMap<Fatura, FaturaDto>();
            CreateMap<FaturaDto, Fatura>();
            CreateMap<Fatura, FaturaWithTahsilatDetayDto>();
            CreateMap<FaturaWithTahsilatDetayDto, Fatura>();
            CreateMap<Fatura, FaturaWithTahsilatDto>();
            CreateMap<FaturaWithTahsilatDto, Fatura>();
            CreateMap<Tahsilat, TahsilatDto>();
            CreateMap<TahsilatDto, Tahsilat>();
            CreateMap<TahsilatDetay, TahsilatDetayDto>();
            CreateMap<TahsilatDetayDto, TahsilatDetay>();
        }
    }
}

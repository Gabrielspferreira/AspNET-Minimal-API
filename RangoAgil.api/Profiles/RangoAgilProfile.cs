using AutoMapper;
using RangoAgil.api.Entities;
using RangoAgil.api.Models;

namespace RangoAgil.api.Profiles;

public class RangoAgilProfile : Profile
{
    public RangoAgilProfile() 
    {
        CreateMap<Rango, RangoDTO>().ReverseMap();
        CreateMap<Ingrediente, IngredienteDTO>()
            .ForMember(
            d => d.RangoId,
            o => o.MapFrom(s => s.Rangos.First().Id));
    }
}


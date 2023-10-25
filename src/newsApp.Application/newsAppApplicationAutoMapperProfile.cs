using AutoMapper;
 feature/3-lista-de-busquedas
using newsApp.Busquedas;

using newsApp.Temas;


namespace newsApp;

public class newsAppApplicationAutoMapperProfile : Profile
{
    public newsAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
 feature/3-lista-de-busquedas
        CreateMap<Busqueda, BusquedaDto>();

        CreateMap<Tema, TemaDto>();

    }
}

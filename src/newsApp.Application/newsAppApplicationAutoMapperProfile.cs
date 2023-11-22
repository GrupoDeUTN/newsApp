using AutoMapper;
using newsApp.Temas;
using newsApp.Noticias;
using newsApp.Busquedas;
using newsApp.News;

namespace newsApp;

public class newsAppApplicationAutoMapperProfile : Profile
{
    public newsAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Tema, TemaDto>();
        CreateMap<Noticia, NoticiaDto>();
        CreateMap<Busqueda, BusquedaDto>();
        CreateMap<NewsDto, ArticleDto>().ReverseMap();
    }
}

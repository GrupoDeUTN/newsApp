using AutoMapper;
 feature/2-obtención-de-noticias
using newsApp.Noticias;

using newsApp.Busquedas;
using newsApp.Notificaciones;
using newsApp.Temas;
 master

namespace newsApp;

public class newsAppApplicationAutoMapperProfile : Profile
{
    public newsAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
 feature/2-obtención-de-noticias
        CreateMap<Noticia, NoticiaDto>();


 feature/3-lista-de-busquedas
        CreateMap<Busqueda, BusquedaDto>();
        CreateMap<Notificacion, NotificacionDto>();
        CreateMap<Tema, TemaDto>();

 master
    }
}

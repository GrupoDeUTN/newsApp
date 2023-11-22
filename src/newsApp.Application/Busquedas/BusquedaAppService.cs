using newsApp.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace newsApp.Busquedas
{
    public class BusquedaAppService : CrudAppService< Busqueda, BusquedaDto, int>, IBusquedaAppService 
    {
        public BusquedaAppService(IRepository<Busqueda, int> repository)
            : base(repository)
        {

        }

      //  public List<Noticia> GetHelloWorld()
       // {
         //   Noticia n = new Noticia();
           // n.Titulo = "tit";
           // return n;
       // }

    }
}

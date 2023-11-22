using Microsoft.AspNetCore.Mvc;
using newsApp.Busquedas;
using newsApp.News;
using newsApp.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace newsApp.Controllers
{
    [Route("api/ejemplo")]
    public  class BusquedaApi  : AbpControllerBase
    {

   //     private readonly BusquedaAppService _busquedaAppService;

        private readonly INewsAppService _newsService;
        public BusquedaApi(INewsAppService newsAppService)
        {
            _newsService = newsAppService;
        }

          [HttpGet]
          [Route("BusquedaEjemplo")]
        public  ICollection< NewsDto> GetHelloWorld( string temaABuscar)
          {
              var resultado = _newsService.Search(temaABuscar).Result;

              return resultado;
           }


        //  [HttpGet]
        //  [Route("hello")]
        //  public  List< Noticia> GetHelloWorld( string temaABuscar)
        //  {
        //      var resultado = _busquedaAppService.GetHelloWorld();

        //      return resultado;
        //   }
    }
}

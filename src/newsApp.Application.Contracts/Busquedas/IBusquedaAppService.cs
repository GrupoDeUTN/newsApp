using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace newsApp.Busquedas
{
    public interface IBusquedaAppService : ICrudAppService< BusquedaDto, int>
    {

    }
}

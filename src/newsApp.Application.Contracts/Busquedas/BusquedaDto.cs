using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace newsApp.Busquedas
{
    public class BusquedaDto : EntityDto<int>
    {
        public string Texto { get; set; }
        //public DateTime Fecha { get; set; }
    }
}

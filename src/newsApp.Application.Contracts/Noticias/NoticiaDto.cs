using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace newsApp.Noticias
{
    public class NoticiaDto : EntityDto<string>
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Autor { get; set; }
        public string Fuente { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}

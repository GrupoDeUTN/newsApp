using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace newsApp.Noticias
{
    public class Noticia : Entity<string>
    {

        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Descripcion { get; set; }
        public string Autor { get; set; }
        public string Fuente { get; set; }
        public DateTime FechaIngreso { get; set; }
        //Foto
    }
}

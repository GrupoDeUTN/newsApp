using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace newsApp.Busquedas
{
    public class Busqueda : Entity<int>
    {
        public string Texto { get; set; }
        //public DateTime Fecha { get; set; }
        //donde se le pone si arrajo o no busquedas
    }
}

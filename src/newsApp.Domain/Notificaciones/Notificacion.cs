﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace newsApp.Notificaciones
{
    public  class Notificacion:Entity<int>
    {
        public string mensajeDeTextoEncontrado { get; set; }
        public DateTime fechaAviso { get; set; }

    }
}

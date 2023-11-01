using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace newsApp.Notificaciones
{
    public class NotificacionDto: EntityDto<int>
    {
        public string mensajeDeTextoEncontrado { get; set; }
        public DateTime fechaAviso { get; set; }
    }
}

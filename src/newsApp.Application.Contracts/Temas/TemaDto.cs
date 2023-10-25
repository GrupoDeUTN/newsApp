using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace newsApp.Temas
{
    public class TemaDto : EntityDto<int> 
    {
        public string Nombre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace newsApp.Temas
{
    public interface ITemaAppService :  ICrudAppService<TemaDto,int>
    {

    }
}

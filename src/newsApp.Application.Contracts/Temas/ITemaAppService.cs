using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace newsApp.Temas
{
    public interface ITemaAppService : IApplicationService 
    {
        Task<ICollection<TemaDto>> GetTemasAsync();
    }
}

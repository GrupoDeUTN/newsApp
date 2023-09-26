using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace newsApp.Temas
{
    public class TemaAppService : CrudAppService<Tema, TemaDto, int>, ITemaAppService
    {
        public TemaAppService(IRepository<Tema, int> repository) 
            : base(repository)
        {

        }
    }
}

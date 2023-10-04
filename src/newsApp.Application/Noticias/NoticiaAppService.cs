using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace newsApp.Noticias
{
    public class NoticiaAppService : CrudAppService<Noticia, NoticiaDto, string>, INoticiaAppService 
    {
        public NoticiaAppService(IRepository<Noticia, string> repository)
            : base(repository)
        {

        }
    }
}

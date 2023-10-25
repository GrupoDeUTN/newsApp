using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace newsApp.Temas
{
    public class TemaAppService : newsAppAppService, ITemaAppService
    {
        private readonly IRepository<Tema, int> _repository;
        public TemaAppService(IRepository<Tema, int> repository) 
        {
            _repository = repository;
        }

        public async Task<ICollection<TemaDto>> GetTemasAsync()
        {
            var Temas = await _repository.GetListAsync();

            return ObjectMapper.Map<ICollection<Tema>, ICollection<TemaDto>>(Temas);
        }
    }
}

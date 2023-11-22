using JetBrains.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using NewsApp.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace newsApp.Temas
{
    [Authorize]
    public class TemaAppService : newsAppAppService, ITemaAppService
    {
        private readonly IRepository<Tema, int> _repository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly TemaManager _temaManager;
        public TemaAppService(IRepository<Tema, int> repository, UserManager<IdentityUser> userManager, TemaManager temaManager)
        {
            _repository = repository;
            _userManager = userManager;
            _temaManager = temaManager;
        }

        public async Task<ICollection<TemaDto>> GetTemasAsync()
        {
            var Temas = await _repository.GetListAsync(includeDetails:true );

            return ObjectMapper.Map<ICollection<Tema>, ICollection<TemaDto>>(Temas);
        }

       public async Task<TemaDto> GetTemasAsync(int id)
        {
            var queryable = await _repository.WithDetailsAsync(x => x.Temas);
            var query = queryable.Where(x=> x.Id == id);
            var Tema = await AsyncExecuter.FirstOrDefaultAsync(query);
            return ObjectMapper.Map<Tema, TemaDto>(Tema);
        }

        public async Task<TemaDto> CreateAsync(CreateTemaDto input)
        {
            var userGuid = CurrentUser.Id.GetValueOrDefault();
            var identityUser = await _userManager.FindByIdAsync(userGuid.ToString());
            var Tema = await _temaManager.CreateAsyncOrUpdate(input.Id, input.Name, input.ParentId, identityUser);
                if (input.Id is null)
            {
                Tema = await _repository.InsertAsync(Tema, autoSave: true);
            }
                else
            {
                await _repository.UpdateAsync(Tema, autoSave: true);
            }
            return ObjectMapper.Map<Tema, TemaDto>(Tema);
        }


}
    }


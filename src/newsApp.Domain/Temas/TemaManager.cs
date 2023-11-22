using Microsoft.AspNetCore.Identity;
using newsApp.Temas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace NewsApp.Themes
{
    public class TemaManager : DomainService
    {
        private readonly IRepository<Tema, int> _repository;
        public TemaManager(IRepository<Tema, int> repository)
        {
            _repository = repository;
        }

        public async Task<Tema> CreateAsyncOrUpdate(int? id, string Nombre, int? ParentId, IdentityUser identityUser)
        {
            Tema Tema = null;

            if (id is not null)
            {
                // Si el id no es nulo significa que se modifica el tema
                Tema = await _repository.GetAsync(id.Value, includeDetails: true);

                Tema.Nombre = Nombre;
            }
            else
            {
                //Si el id es nulo, es un tema nuevo
                Tema = new Tema { Nombre = Nombre, User = identityUser };

                if (ParentId is not null)
                {
                    // Si el parent id no es nulo, es un tema hijo de un tema padre.
                    var parentTheme = await _repository.GetAsync(ParentId.Value, includeDetails: true);
                    parentTheme.Temas.Add(Tema);
                }
            };

            return Tema;
        }
    }
}

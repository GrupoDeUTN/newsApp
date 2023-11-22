using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;

namespace newsApp.Temas
{
    public class Tema : Entity<int>
    {
        public string Nombre { get; set; }
        public IdentityUser User { get; set; }
        public ICollection<Tema> Temas { get; set; }
    }
}

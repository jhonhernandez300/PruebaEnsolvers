using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBackend.CORE.Models;

namespace SmartBackend.CORE.Interfaces
{
    public interface INoteRepository : IBaseRepository<Cliente>
    {
        //IEnumerable<Note> SpecialMethod();
    }
}

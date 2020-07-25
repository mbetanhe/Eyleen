using Eyleen.CORE.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eyleen.CORE.Interfaces
{
    public interface IDimEstadosRepository
    {
        Task<IEnumerable<DimEstados>> GetTodos();
    }
}

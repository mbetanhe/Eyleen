using Eyleen.CORE.Entities;
using Eyleen.CORE.Interfaces;
using Eyleen.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eyleen.INFRASTRUCTURE.Repositories
{
    public class DimEstadosRepository : IDimEstadosRepository
    {
        private readonly EyleenDBContext _context;

        public DimEstadosRepository(EyleenDBContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<DimEstados>> GetTodos()
        {
            List<DimEstados> result = await _context.DimEstados.ToListAsync();
            return result;
        }
    }
}

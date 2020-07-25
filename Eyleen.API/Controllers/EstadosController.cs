using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eyleen.CORE.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eyleen.API.Controllers
{
    [Route("api/estados")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        private readonly IDimEstadosRepository _repository;

        public EstadosController(IDimEstadosRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<CORE.Entities.DimEstados> result = await _repository.GetTodos();

            return Ok(result);
        }
    }
}
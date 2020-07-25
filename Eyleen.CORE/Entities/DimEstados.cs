using System;
using System.Collections.Generic;

namespace Eyleen.CORE.Entities
{
    public partial class DimEstados
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Modulo { get; set; }
    }
}

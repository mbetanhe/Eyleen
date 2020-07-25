using System;
using System.Collections.Generic;

namespace Eyleen.CORE.Entities
{
    public partial class HistEstados
    {
        public int Id { get; set; }
        public int EstadoId { get; set; }
        public int ClienteId { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

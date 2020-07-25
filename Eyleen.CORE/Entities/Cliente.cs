using System;
using System.Collections.Generic;

namespace Eyleen.CORE.Entities
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Dirección { get; set; }
        public string Celular { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}

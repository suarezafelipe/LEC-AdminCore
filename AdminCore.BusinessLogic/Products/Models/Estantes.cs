using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Estantes
    {
        public Estantes()
        {
            ArticulosEntradosEstantes = new HashSet<ArticulosEntradosEstantes>();
        }

        public int IdEstante { get; set; }
        public string CodigoEstante { get; set; }
        public string TipoEstante { get; set; }
        public string Agrupamiento { get; set; }
        public bool EstaLleno { get; set; }
        public bool EstaDisponible { get; set; }
        public string Concepto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public byte[] RowVersion { get; set; }
        public int IdBodega { get; set; }

        public Bodegas IdBodegaNavigation { get; set; }
        public ICollection<ArticulosEntradosEstantes> ArticulosEntradosEstantes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class CategoriasContabilidad
    {
        public CategoriasContabilidad()
        {
            CategoriasCategoriasContable = new HashSet<CategoriasCategoriasContable>();
            Productos = new HashSet<Productos>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int CuentaContable { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public string TipoIva { get; set; }

        public ICollection<CategoriasCategoriasContable> CategoriasCategoriasContable { get; set; }
        public ICollection<Productos> Productos { get; set; }
    }
}

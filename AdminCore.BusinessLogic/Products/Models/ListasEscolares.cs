using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ListasEscolares
    {
        public ListasEscolares()
        {
            ArticulosPorLista = new HashSet<ArticulosPorLista>();
            DetallesListaPedido = new HashSet<DetallesListaPedido>();
            HistoricoListas = new HashSet<HistoricoListas>();
        }

        public int IdLista { get; set; }
        public string CodUnicoListaencasa { get; set; }
        public string Origen { get; set; }
        public int? AnoLista { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdCurso { get; set; }
        public string Alerta { get; set; }

        public Cursos IdCursoNavigation { get; set; }
        public ICollection<ArticulosPorLista> ArticulosPorLista { get; set; }
        public ICollection<DetallesListaPedido> DetallesListaPedido { get; set; }
        public ICollection<HistoricoListas> HistoricoListas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class BeneficiosAliados
    {
        public BeneficiosAliados()
        {
            BeneficiariosValidos = new HashSet<BeneficiariosValidos>();
        }

        public int IdBeneficio { get; set; }
        public bool EsCostoEnvioGratis { get; set; }
        public bool EsCostoMarcadoGratis { get; set; }
        public int? IdCodigoDescuento { get; set; }
        public int IdIndividuo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public Descuentos IdCodigoDescuentoNavigation { get; set; }
        public Instituciones IdIndividuoNavigation { get; set; }
        public ICollection<BeneficiariosValidos> BeneficiariosValidos { get; set; }
    }
}

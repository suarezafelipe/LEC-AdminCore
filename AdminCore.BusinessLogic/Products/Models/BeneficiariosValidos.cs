using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class BeneficiariosValidos
    {
        public int IdBeneficiario { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string CorreoIdentificacion { get; set; }
        public int IdBeneficio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public bool EstaActivo { get; set; }

        public BeneficiosAliados IdBeneficioNavigation { get; set; }
    }
}

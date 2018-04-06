using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class UbicPersonas
    {
        public int UbicacionesIdUbicacion { get; set; }
        public int PersonasIdIndividuo { get; set; }

        public Personas PersonasIdIndividuoNavigation { get; set; }
        public Ubicaciones UbicacionesIdUbicacionNavigation { get; set; }
    }
}

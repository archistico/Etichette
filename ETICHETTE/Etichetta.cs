using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICHETTE
{
    public class Etichetta
    {
        public int Id { get; set; }
        public string Denominazione { get; set; }
        public double MargineSuperiore { get; set; }
        public double MargineLaterale { get; set; }
        public double Altezza { get; set; }
        public double Larghezza { get; set; }
        public double PassoVerticale { get; set; }
        public double PassoOrizzontale { get; set; }
        public double QtOrizzontale { get; set; }
        public double QtVerticale { get; set; }
        public double PaginaLarghezza { get; set; }
        public double PaginaAltezza { get; set; }

        public Fornitore FornitoreEtichetta { get; set; }

        public bool Attivo { get; set; }

        public string DenominazioneCompleta => $"{FornitoreEtichetta.Denominazione} - {Denominazione}";
        
    }
}

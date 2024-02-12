using System.Collections.Generic;

namespace menuRistorante
{
    internal class cliente
    {

        public string nome { get; set; }
        public string cognome { get; set; }

        public List<float> CibiOrdinati { get; set; }
        public List<string> OrdiniScritti { get; set; }

        public cliente()
        {
            this.nome = "";
            this.cognome = "";
            this.CibiOrdinati = new List<float>();
            this.OrdiniScritti = new List<string>();
        }
    }
}

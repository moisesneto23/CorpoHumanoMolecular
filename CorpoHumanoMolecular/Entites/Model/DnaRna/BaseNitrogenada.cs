using CorpoHumanoMolecular.Service;

namespace CorpoHumanoMolecular.Entites.Model.DnaRna
{
    public class BaseNitrogenada
    {
        private AtomoService criandoAtomo; 
        public BaseNitrogenada(char sigla)
        {
            criandoAtomo = new AtomoService();
            string s = sigla.ToString();
            Atomos = new List<Atomo>();
            switch (s)
            {
                case "A":
                    Nome = "Adenina";
                    Sigla = s;
                    Atomos.Add(criandoAtomo.Carbono(5));
                    Atomos.Add(criandoAtomo.Nitrogenio(5));
                    Atomos.Add(criandoAtomo.Hidrogencio(5));
                    break;
                case "C":
                    Nome = "Citosina";
                    Sigla = s;
                    Atomos.Add(criandoAtomo.Carbono(4));
                    Atomos.Add(criandoAtomo.Nitrogenio(3));
                    Atomos.Add(criandoAtomo.Hidrogencio(5));
                    Atomos.Add(criandoAtomo.Oxigenio(1));
                    break;
                case "T":
                    Nome = "Timina";
                    Sigla = s;
                    Atomos.Add(criandoAtomo.Carbono(12));
                    Atomos.Add(criandoAtomo.Nitrogenio(4));
                    Atomos.Add(criandoAtomo.Hidrogencio(17));
                    Atomos.Add(criandoAtomo.Oxigenio(1));
                    Atomos.Add(criandoAtomo.Enxofre(1));
                    break;
                case "G":
                    Nome = "Guanina";
                    Sigla = s;
                    Atomos.Add(criandoAtomo.Carbono(5));
                    Atomos.Add(criandoAtomo.Nitrogenio(5));
                    Atomos.Add(criandoAtomo.Hidrogencio(5));
                    Atomos.Add(criandoAtomo.Oxigenio(1));
                    break;
                case "U":
                    Nome = "Uracila";
                    Sigla = s;
                    Atomos.Add(criandoAtomo.Carbono(4));
                    Atomos.Add(criandoAtomo.Nitrogenio(2));
                    Atomos.Add(criandoAtomo.Hidrogencio(4));
                    Atomos.Add(criandoAtomo.Oxigenio(2));
                    break;

            }
           
        }

        public string Nome { get; set; }
        public string Sigla { get; set; }
        public List<Atomo> Atomos { get; set; }
        public string FormulaQuimica { get; set; }
        

    }
}

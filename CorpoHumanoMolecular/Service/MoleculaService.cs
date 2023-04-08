using CorpoHumanoMolecular.Entites.Model;

namespace CorpoHumanoMolecular.Service
{
    public class MoleculaService
    {
        private AtomoService atomo;
        public MoleculaService()
        {
            atomo = new AtomoService();
        }
        //Apenas para RNA
        public Molecula Ribose()
        {
            List<Atomo> lista = new List<Atomo>();
            lista.Add(atomo.Carbono(5));
            lista.Add(atomo.Hidrogencio(10));
            lista.Add(atomo.Oxigenio(5));

            Molecula adenina = new Molecula("Adenina", PegaFormulaQuimica(lista), lista);
            return adenina;
        }

        //apenas para DNA
        public Molecula Desoxirribose()
        {
            List<Atomo> lista = new List<Atomo>();
            lista.Add(atomo.Carbono(5));
            lista.Add(atomo.Hidrogencio(10));
            lista.Add(atomo.Oxigenio(4));
            Molecula Desoxirribose = new Molecula("Desoxirribose", PegaFormulaQuimica(lista), lista);
            return Desoxirribose;
        }

        //em DNA e RNA
        public Molecula AcidoFosforico()
        {
            List<Atomo> lista = new List<Atomo>();
            lista.Add(atomo.Fosforo(1));
            lista.Add(atomo.Hidrogencio(3));
            lista.Add(atomo.Oxigenio(4));
            Molecula AcidoFosforico = new Molecula("AcidoFosforico", PegaFormulaQuimica(lista), lista);
            return AcidoFosforico;
        }
        private string PegaFormulaQuimica(List<Atomo> atomos)
        {
            string pegaFormula = "";
            foreach (var atom in atomos)
            {
                pegaFormula += atom.Nome.Substring(0, 1) + atom.Quantidade.ToString();
            }
            return pegaFormula;
            
        }
    }
}

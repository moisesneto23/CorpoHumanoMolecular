using CorpoHumanoMolecular.Entites.Model;
using CorpoHumanoMolecular.Service;

namespace CorpoHumanoMolecular.Repository
{
    public class MoleculaRepository
    {
        private AtomoService atomo;
        public MoleculaRepository()
        {
            atomo = new AtomoService();
        }
        public List<Molecula> BuscaTodas()
        {
            List<Molecula> list = new List<Molecula>();
            list.Add(Adenina());

            return list;
        }


        private Molecula Adenina()
        {
            List<Atomo> lista = new List<Atomo>();
            lista.Add(atomo.Carbono(5));
            lista.Add(atomo.Hidrogencio(5));
            lista.Add(atomo.Nitrogenio(5));

            Molecula adenina = new Molecula("Adenina", PegaFormulaQuimica(lista), lista);
            return adenina;
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

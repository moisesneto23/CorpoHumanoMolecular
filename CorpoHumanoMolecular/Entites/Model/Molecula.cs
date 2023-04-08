namespace CorpoHumanoMolecular.Entites.Model
{
    public class Molecula
    {
        public Molecula(string nome, string formula, List<Atomo> listaAtomos)
        {
            Nome = nome;
            Formula = formula;
            ListaAtomos = listaAtomos;
        }

        public string Nome { get; set; }
        public string Formula { get; set; }
        public List<Atomo> ListaAtomos { get; set; }
        
    }
}

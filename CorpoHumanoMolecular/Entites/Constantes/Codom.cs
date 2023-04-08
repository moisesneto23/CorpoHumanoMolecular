using CorpoHumanoMolecular.Entites.Model;

namespace CorpoHumanoMolecular.Entites.Constantes
{
    public  class Codon
    {
        public Codon(string nome, List<Nucletidio> nucleotideo)
        {
            Nome = nome;
            Nucleotideo = nucleotideo;
        }

        public string Nome { get; set; }
        public List<Nucletidio> Nucleotideo { get; set; }
    }
}

using CorpoHumanoMolecular.Entites.Model;

namespace CorpoHumanoMolecular.Service
{
    public class DnaRnaService
    {
        public DnaRnaService()
        {

        }
        public List<Nucletidio> FitaDna(string gene)
        {
            List<Nucletidio> Gene = new List<Nucletidio>();
            List<string> list = new List<string>();
            gene = gene.ToUpper();
            gene = gene.Trim();
            var array = gene.ToArray();
            int c = gene.Length;
            for (int i = 0; i < array.Length; i++)
            {
                var a = new Nucletidio("DNA", array[i]);
                Gene.Add(a);
            }
            return Gene;

        }

        public List<Nucletidio> FitaRna(string gene)
        {
            List<Nucletidio> Gene = new List<Nucletidio>();
            List<string> list = new List<string>();
            gene = gene.ToUpper();
            gene = gene.Trim();
            var array = gene.ToArray();
            int c = gene.Length;
            for (int i = 0; i < array.Length; i++)
            {
                var a = new Nucletidio("RNA", array[i]);
                Gene.Add(a);
            }
            return Gene;

        }
    }
}

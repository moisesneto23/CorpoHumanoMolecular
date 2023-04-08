using CorpoHumanoMolecular.Entites.Constantes;
using CorpoHumanoMolecular.Entites.Model;
using CorpoHumanoMolecular.Service;

namespace CorpoHumanoMolecular.Repository
{
    public class CodonRepository
    {
      
        public Codon FenilAlanina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("FenilAlanina", nucleotidios);
            return cod;
        }

        public Codon Leucina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Leucina", nucleotidios);
            return cod;
        }

        public Codon Isoleucina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Isoleucina", nucleotidios);
            return cod;
        }

        public Codon MetioninaIniciaCodon(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Metionina", nucleotidios);
            return cod;
        }

        public Codon Valina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Valina", nucleotidios);
            return cod;
        }

        public Codon Serina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Serina", nucleotidios);
            return cod;
        }

        public Codon Treonina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Treonina", nucleotidios);
            return cod;
        }

        public Codon Alanina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Alanina", nucleotidios);
            return cod;
        }

        public Codon Tirosina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Leucina", nucleotidios);
            return cod;
        }

        public Codon ParaCodon(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Leucina", nucleotidios);
            return cod;
        }

        public Codon Histidina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Histidina", nucleotidios);
            return cod;
        }

        public Codon Glutamina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Glutamina", nucleotidios);
            return cod;
        }

        public Codon Prolina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Asparagina", nucleotidios);
            return cod;
        }

        public Codon Asparagina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Asparagina", nucleotidios);
            return cod;
        }

        public Codon Lisina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Lisina", nucleotidios);
            return cod;
        }

        public Codon AcidoAspartico(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("AcidoAspartico", nucleotidios);
            return cod;
        }

        public Codon AcidoGlutamico(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("AcidoGlutamico", nucleotidios);
            return cod;
        }


        public Codon Cisteine(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Cisteine", nucleotidios);
            return cod;
        }

        public Codon ParaCodonTriptophan(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Leucina", nucleotidios);
            return cod;
        }
       
        public Codon Arginina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Leucina", nucleotidios);
            return cod;
        }
        public Codon Glicina(string codon)
        {
            var nucleotidios = GeraCodon(codon);
            Codon cod = new("Leucina", nucleotidios);
            return cod;
        }

        private List<Nucletidio> GeraCodon(string gene)
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

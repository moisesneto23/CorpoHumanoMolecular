using CorpoHumanoMolecular.Entites.Constantes;
using CorpoHumanoMolecular.Entites.Model;
using CorpoHumanoMolecular.Repository;

namespace CorpoHumanoMolecular.Service
{
    public class CodonService
    {
        private readonly CodonRepository codon;
        public CodonService()
        {
            codon = new CodonRepository();
        }

        private Codon PegaCodon(string cod)
        {
            switch (cod)
            {
                case "" :
                    return codon.FenilAlanina(cod);
                    break;
                case "":
                    return codon.FenilAlanina(cod);
                    break;
                case "":
                    return codon.Leucina(cod);
                    break;
                case "":
                    return codon.Leucina(cod);
                    break;
                case "":
                    return codon.Leucina(cod);
                    break;
                case "":
                    return codon.Leucina(cod);
                    break;
                case "":
                    return codon.Isoleucina(cod);
                    break;
                case "":
                    return codon.Isoleucina(cod);
                    break;
                case "":
                    return codon.Isoleucina(cod);
                    break;
                case "":
                    return codon.MetioninaIniciaCodon(cod);
                    break;
                case "":
                    return codon.Valina(cod);
                    break;
                case "":
                    return codon.Valina(cod);
                    break;
                case "":
                    return codon.Valina(cod);
                    break;
                case "":
                    return codon.Valina(cod);
                    break;
                case "":
                    return codon.Serina(cod);
                    break;
                case "":
                    return codon.Serina(cod);
                    break;
                case "":
                    return codon.Serina(cod);
                    break;
                case "":
                    return codon.Serina(cod);
                    break;
                case "":
                    return codon.Serina(cod);
                    break;
                case "":
                    return codon.Serina(cod);
                    break;
                case "":
                    return codon.Prolina(cod);
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}

using CorpoHumanoMolecular.Entites.Model.DnaRna;
using CorpoHumanoMolecular.Service;

namespace CorpoHumanoMolecular.Entites.Model
{
    public class Nucletidio
    {
        MoleculaService molecula;
        public Nucletidio(string Tipo, char baseNitrogenada)
        {
            molecula = new MoleculaService();
            Tipo = Tipo.ToUpper();
            if(Tipo == "DNA")
            {
                BaseNitrogenada = new BaseNitrogenada(baseNitrogenada) ;
                Acucar = molecula.Desoxirribose();
            }
            else if(Tipo == "RNA")
            {
                BaseNitrogenada = new BaseNitrogenada(baseNitrogenada);
                Acucar = molecula.Ribose();
            }
            GrupoFosfato = molecula.AcidoFosforico();
            
        }

        public BaseNitrogenada BaseNitrogenada { get; private set; }
        public Molecula GrupoFosfato { get; private set; }
        public Molecula Acucar { get; private set; }
    }
}

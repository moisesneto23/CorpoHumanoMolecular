using CorpoHumanoMolecular.Entites.Model;

namespace CorpoHumanoMolecular.Service
{
    public class AtomoService
    {
        public Atomo Carbono(int quantidade)
        {
            return new Atomo("Carbono",6,12,quantidade);
        }
        public Atomo Hidrogencio(int quantidade)
        {
            return new Atomo("Hidrogencio", 1, 1, quantidade);
        }
        public Atomo Nitrogenio(int quantidade)
        {
            return new Atomo("Nitrogenio", 7, 14, quantidade);
        }

        public Atomo Oxigenio(int quantidade)
        {
            return new Atomo("Oxigenio", 8, 16, quantidade);
        }
        public Atomo Enxofre(int quantidade)
        {
            return new Atomo("Enxofre", 16, 30, quantidade);
        }
        public Atomo Fosforo(int quantidade)
        {
            return new Atomo("Enxofre", 15, 31, quantidade);
        }

    }
}

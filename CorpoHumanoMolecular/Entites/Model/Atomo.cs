namespace CorpoHumanoMolecular.Entites.Model
{
    public class Atomo
    {
        public Atomo(string nome, int numeroAtomico, int massaAtomica, int quantidade)
        {
            Nome = nome;
            NumeroAtomico = numeroAtomico;
            MassaAtomica = massaAtomica;
            Quantidade = quantidade;
            MassaTotal = quantidade * massaAtomica;
        }

        public string Nome { get; set; }
        public int NumeroAtomico { get; private set; }
        public int MassaAtomica { get; private set; }
        public int Quantidade { get; set; }
        public int MassaTotal { get; set; }
        

        
    }
}

namespace SisecomChallenge.Models
{
    public class Piloto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Equipe { get; set; } = string.Empty;
        public TimeSpan MelhorVolta { get; set; }
        public TipoCategoria Categoria { get; set; }
        public ClassePeso Peso { get; set; }
        public TipoSexo Sexo { get; set; }
        public string Nacionalidade { get; set; } = string.Empty;
        public string Tracado { get; set; } = string.Empty;
        public enum TipoCategoria
        {
            Formula1,
            Endurance,
            Kart,
            StockCar
        }
        public enum TipoSexo
        {
            Masculino,
            Feminino
        }
        public enum ClassePeso
        {
            Leve,
            Medio,
            Pesado
        }
    }
}

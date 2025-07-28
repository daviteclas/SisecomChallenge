using SisecomChallenge.Data;
using SisecomChallenge.Models;
using static SisecomChallenge.Models.Piloto;

public class PilotoService : IPilotoService
{
    private static readonly List<Piloto> _pilotos = new List<Piloto>
    {
        // Adicione aqui pelo menos 10 pilotos fictícios
        new Piloto { Id = 1, Nome = "Ayrton Senna", Equipe = "McLaren", MelhorVolta = new TimeSpan(0, 1, 22, 345), Categoria = TipoCategoria.Formula1, Peso = ClassePeso.Leve, Sexo = TipoSexo.Masculino, Nacionalidade = "Brasil", Tracado = "Interlagos" },
        new Piloto { Id = 2, Nome = "Michael Schumacher", Equipe = "Ferrari", MelhorVolta = new TimeSpan(0, 1, 21, 888), Categoria = TipoCategoria.Formula1, Peso = ClassePeso.Leve, Sexo = TipoSexo.Masculino, Nacionalidade = "Alemanha", Tracado = "Spa-Francorchamps" },
        new Piloto { Id = 3, Nome = "Lewis Hamilton", Equipe = "Mercedes", MelhorVolta = new TimeSpan(0, 1, 23, 111), Categoria = TipoCategoria.Formula1, Peso = ClassePeso.Leve, Sexo = TipoSexo.Masculino, Nacionalidade = "Inglaterra", Tracado = "Interlagos" },
        new Piloto { Id = 4, Nome = "Bia Figueiredo", Equipe = "Ipiranga Racing", MelhorVolta = new TimeSpan(0, 2, 10, 500), Categoria = TipoCategoria.StockCar, Peso = ClassePeso.Pesado, Sexo = TipoSexo.Feminino, Nacionalidade = "Brasil", Tracado = "Interlagos" },
        new Piloto { Id = 5, Nome = "Tom Kristensen", Equipe = "Audi Sport", MelhorVolta = new TimeSpan(0, 3, 15, 987), Categoria = TipoCategoria.Endurance, Peso = ClassePeso.Medio, Sexo = TipoSexo.Masculino, Nacionalidade = "Dinamarca", Tracado = "Le Mans" },
        new Piloto { Id = 6, Nome = "Max Verstappen", Equipe = "Red Bull Racing", MelhorVolta = new TimeSpan(0, 1, 20, 932), Categoria = TipoCategoria.Formula1, Peso = ClassePeso.Leve, Sexo = TipoSexo.Masculino, Nacionalidade = "Holanda", Tracado = "Spa-Francorchamps" },
        new Piloto { Id = 7, Nome = "Lella Lombardi", Equipe = "March Engineering", MelhorVolta = new TimeSpan(0, 1, 35, 400), Categoria = TipoCategoria.Formula1, Peso = ClassePeso.Leve, Sexo = TipoSexo.Feminino, Nacionalidade = "Itália", Tracado = "Monza" },
        new Piloto { Id = 8, Nome = "Tony Kanaan", Equipe = "Chip Ganassi", MelhorVolta = new TimeSpan(0, 2, 5, 200), Categoria = TipoCategoria.Endurance, Peso = ClassePeso.Medio, Sexo = TipoSexo.Masculino, Nacionalidade = "Brasil", Tracado = "Daytona" },
        new Piloto { Id = 9, Nome = "Pedro Piquet", Equipe = "Texaco Racing", MelhorVolta = new TimeSpan(0, 0, 45, 750), Categoria = TipoCategoria.Kart, Peso = ClassePeso.Leve, Sexo = TipoSexo.Masculino, Nacionalidade = "Brasil", Tracado = "Kartódromo de Birigui" },
        new Piloto { Id = 10, Nome = "Sabine Schmitz", Equipe = "BMW", MelhorVolta = new TimeSpan(0, 6, 50, 123), Categoria = TipoCategoria.Endurance, Peso = ClassePeso.Medio, Sexo = TipoSexo.Feminino, Nacionalidade = "Alemanha", Tracado = "Nürburgring" }
    };

    public Task<List<Piloto>> GetPilotosAsync()
    {
        return Task.FromResult(_pilotos);
    }
}
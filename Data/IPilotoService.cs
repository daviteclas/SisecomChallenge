using SisecomChallenge.Models;

namespace SisecomChallenge.Data
{
    public interface IPilotoService
    {
        Task<List<Piloto>> GetPilotosAsync();
    }
}

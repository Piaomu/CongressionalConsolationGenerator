using CongressionalConsolationGenerator.Models;

namespace CongressionalConsolationGenerator.Services
{
    public interface ICondolenceService
    {
        public Task<Condolence> GenerateCalculatedCondolence(CondolenceInput condolenceInput);
        public Task<Condolence> GenerateRandomCondolence();

    }
}

using CongressionalConsolationGenerator.Models;

namespace CongressionalConsolationGenerator.Services
{
    public class CondolenceService : ICondolenceService
    {
        public async Task<Condolence> GenerateCalculatedCondolence(CondolenceInput condolenceInput)
        {
            throw new NotImplementedException();
        }

        public async Task<Condolence> GenerateRandomCondolence()
        {
            Condolence condolence = new()
            {
                SentenceSubject = GetRandomSubject(),
            };

            return condolence;
        }

        private async Task<Subject> GetSubjectAsync(Subject subject)
        {
            throw new NotImplementedException();
        }

        private Subject GetRandomSubject()
        {
            Array values = Enum.GetValues(typeof(Subject));
            Random random = new Random();
            Subject subject = (Subject)values.GetValue(random.Next(values.Length));

            return subject;
        }
    }
}

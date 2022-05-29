using CongressionalConsolationGenerator.Models;
using System.ComponentModel.DataAnnotations;

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
            var verb1 = GetRandomVerb();

            Condolence condolence = new()
            {
                SentenceSubject = GetRandomSubject(),
                Verb1 = verb1,
                IsDoubleVerb = FlipCoin(),
                Verb2 = GetSecondVerb(verb1),
                Tragedy = GetRandomTragedy()
                


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

        private Verb GetRandomVerb()
        {
            Array values = Enum.GetValues(typeof(Verb));
            Random random = new Random();
            Verb verb = (Verb)values.GetValue(random.Next(values.Length));

            return verb;
        }

        private Verb GetSecondVerb(Verb verb1)
        {
            Verb secondVerb = GetRandomVerb();

            while (secondVerb == verb1)
            {
              secondVerb = GetRandomVerb();
            }

            return secondVerb;
        }

        private bool FlipCoin()
        {
            Random random = new Random();
            bool coin = false;

            int flip = random.Next();

            if(flip % 2 == 0)
            {
                coin = true;
            }
            return coin;
        }

        private Tragedy GetRandomTragedy()
        {
            Array values = Enum.GetValues(typeof(Tragedy));
            Random random = new Random();
            Tragedy tragedy = (Tragedy)values.GetValue(random.Next(values.Length));

            return tragedy;
        }

    }
}

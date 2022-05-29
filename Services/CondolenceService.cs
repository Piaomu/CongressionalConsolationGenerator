using CongressionalConsolationGenerator.Models;
using Newtonsoft.Json;
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
            var year = GetYear();
            var TragicEvent = GetEventDetailsAsync(year);

            Condolence condolence = new()
            {
                SentenceSubject = GetRandomSubject(),
                Verb1 = verb1,
                IsDoubleVerb = FlipCoin(),
                Verb2 = GetSecondVerb(verb1),
                Tragedy = GetRandomTragedy(),
                Year = year,
                Location = TragicEvent.Location,
                State = TragicEvent.State,
                Date = TragicEvent.Date

                


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

        private bool FlipCoin()
        {
            Random random = new Random();
            bool coin = false;

            int flip = random.Next();

            if (flip % 2 == 0)
            {
                coin = true;
            }
            return coin;
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

        private Tragedy GetRandomTragedy()
        {
            Array values = Enum.GetValues(typeof(Tragedy));
            Random random = new Random();
            Tragedy tragedy = (Tragedy)values.GetValue(random.Next(values.Length));

            return tragedy;
        }

        private Year GetYear()
        {
            Array values = Enum.GetValues(typeof(Tragedy));
            Random random = new Random();
            Year year = (Year)values.GetValue(random.Next(values.Length));

            return year;
        }

        private EventDetails GetEventDetailsAsync(Year year)
        {
            string fileName;

            if(year == Year.Thirteen)
            {
                fileName = "2013-data.json";
            }
            else if(year == Year.Fourteen)
            {
                fileName = "2014-data.json";
            }
            else if(year == Year.Fifteen)
            {
                fileName = "2015-data.json";
            }
            else if(year == Year.Sixteen)
            {
                fileName = "2016-data.json";
            }
            else if(year == Year.Seventeen){
                fileName = "2017-data.json";
            }
            else if(year == Year.Eighteen)
            {
                fileName = "2018-data.json";
            }
            else if(year == Year.Nineteen)
            {
                fileName = "2019-data.json";
            }
            else if(year == Year.Twenty)
            {
                fileName = "2020-data.json";
            }
            else if(year == Year.TwentyOne)
            {
                fileName = "2021-data.json";
            }
            else
            {
                fileName = "2022-data.json";
            }

            string path = "C:\\Users\\drift\\source\\repos\\CongressionalConsolationGenerator\\Json\\";

            string fullPath = $"{path}{fileName}";

            using (StreamReader openStream = File.OpenText(fullPath))
            {
                JsonSerializer serializer = new JsonSerializer();

                ShootingDataRoot shootingDataRoot = (ShootingDataRoot)serializer.Deserialize(openStream, typeof(ShootingDataRoot));
            };

            EventDetails details = new();



            return details;
        }

    }
}

using CongressionalConsolationGenerator.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            var year = GetRandomYear();
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
                Date = TragicEvent.Date,
                ThoughtsAndPrayers = GetRandomThoughtPrayer(),
                Sentence2Object = GetRandomSentenceObject(),
                ResponderAdjective = GetRandomAdjective(),
                Heroes = GetRandomHeroes(),
                Signature = GetSignature()

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

        private Year GetRandomYear()
       {
            Array values = Enum.GetValues(typeof(Year));
            Random random = new Random();
            Year year = (Year)values.GetValue(random.Next(values.Length));

            return year;
        }

        private List<ShootingData> GetShootingDataByYear(Year year)
        {
            string fileName;

            if (year == Year.Thirteen)
            {
                fileName = "2013-data.json";
            }
            else if (year == Year.Fourteen)
            {
                fileName = "2014-data.json";
            }
            else if (year == Year.Fifteen)
            {
                fileName = "2015-data.json";
            }
            else if (year == Year.Sixteen)
            {
                fileName = "2016-data.json";
            }
            else if (year == Year.Seventeen)
            {
                fileName = "2017-data.json";
            }
            else if (year == Year.Eighteen)
            {
                fileName = "2018-data.json";
            }
            else if (year == Year.Nineteen)
            {
                fileName = "2019-data.json";
            }
            else if (year == Year.Twenty)
            {
                fileName = "2020-data.json";
            }
            else if (year == Year.TwentyOne)
            {
                fileName = "2021-data.json";
            }
            else
            {
                fileName = "2022-data.json";
            }

            string path = "C:\\Users\\drift\\source\\repos\\CongressionalConsolationGenerator\\Json\\";

            string fullPath = $"{path}{fileName}";

            if(fullPath is null)
            {
                throw new Exception("Path returned no value");
            }

            using (StreamReader openStream = File.OpenText(fullPath))
            {
                string jsonString = openStream.ReadToEnd();
                var jsonArray = JArray.Parse(jsonString);

                List<ShootingData> shootingDataList = jsonArray.ToObject<List<ShootingData>>();


                return shootingDataList;
            };

        }
        private EventDetails GetEventDetailsAsync(Year year)
        {
            var shootingDataByYear = GetShootingDataByYear(year);

            ShootingData shootingEvent = GetEvent(shootingDataByYear);

            EventDetails details = new()
            {
                Date = shootingEvent.Date,
                Location = shootingEvent.City,
                State = shootingEvent.State,
                Year = year
            };

            return details;
        }

        private ShootingData GetEvent(List<ShootingData> shootingDataByYear)
        {
            Random random = new Random();
            var randomIndex = random.Next(0, shootingDataByYear.Count);

            var shootingEvent = shootingDataByYear[randomIndex];

            return shootingEvent;
        }

        private ThoughtPrayer GetRandomThoughtPrayer()
        {
            Array values = Enum.GetValues(typeof(ThoughtPrayer));
            Random random = new Random();
            ThoughtPrayer thoughtPrayer = (ThoughtPrayer)values.GetValue(random.Next(values.Length));

            return thoughtPrayer;
        }

        private SentenceObject GetRandomSentenceObject()
        {
            Array values = Enum.GetValues(typeof(SentenceObject));
            Random random = new Random();
            SentenceObject sentenceObject = (SentenceObject)values.GetValue(random.Next(values.Length));

            return sentenceObject;
        }

        private Adjective GetRandomAdjective()
        {
            Array values = Enum.GetValues(typeof(Adjective));
            Random random = new Random();
            Adjective adjective = (Adjective)values.GetValue(random.Next(values.Length));
            
            return adjective;
        }

        private Heroes GetRandomHeroes()
        {
            Array values = Enum.GetValues(typeof(Heroes));
            Random random = new Random();
            Heroes heroes = (Heroes)values.GetValue(random.Next(values.Length));

            return heroes;
        }

        private string GetSignature()
        {

            string? signature;

                signature = "Ted Cruz";
            

            return signature;
        }


    }
}

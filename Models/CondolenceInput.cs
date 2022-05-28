namespace CongressionalConsolationGenerator.Models
{
    public class CondolenceInput
    {
        public string Id { get; set; }
        public Subject SentenceSubject { get; set; }
        public Verb Verb { get; set; }
        public Verb? Verb2 { get; set; }
        public bool IsDoubleVerb { get; set; } = false;
        public Tragedy Tragedy { get; set; }
        public Year Year { get; set; }
        public string? Location { get; set; }
        public string? State { get; set; }
        public DateTime Date { get; set; }
        public Subject Sentence2Subject { get; set; }
        public ThoughtPrayer ThoughtsAndPrayers { get; set; }
        public SentenceObject Sentence2Object { get; set; }
        public Adjective ResponderAdjective { get; set; }
        public Heroes Heroes { get; set; }
        public string Signature { get; set; }
    }
}
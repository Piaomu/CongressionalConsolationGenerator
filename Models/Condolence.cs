using System.ComponentModel;

namespace CongressionalConsolationGenerator.Models
{
    public class Condolence
    {
        public Subject SentenceSubject { get; set; }
        public Verb Verb { get; set; }
        public Verb? Verb2 { get; set; }
        public bool IsDoubleVerb { get; set; } = false;
        public Tragedy Tragedy { get; set; }


    }

    public enum Subject
    {
        [Description("I")]
        I,
        [Description("My wife and I")]
        WifeAndI,
        [Description("My husband and I")]
        HusbandAndI,
        [Description("We")]
        We
    }

    public enum Verb 
    { 
        [Description("hearbroken")]
        Heartbroken,
        [Description("devastated")]
        Devastated,
        [Description("horrified")]
        Horrified,
    }

    public enum Tragedy
    {
        SenseLessTragedy,
        LossOfLife,
        Shooting
    }
}

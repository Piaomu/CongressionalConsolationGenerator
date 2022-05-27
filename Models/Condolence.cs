using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CongressionalConsolationGenerator.Models
{
    public class Condolence
    {
        public Subject SentenceSubject { get; set; }
        public Verb Verb { get; set; }
        public Verb? Verb2 { get; set; }
        public bool IsDoubleVerb { get; set; } = false;
        public Tragedy Tragedy { get; set; }
        public string? Location { get; set; }
        public string? State { get; set; }
        public DateTime Date { get; set; }
        public Subject Sentence2Subject { get; set; }
        public ThoughtPrayer ThoughtsAndPrayers { get; set; }
        public SentenceObject Sentence2Object { get; set; }
        public Adjective ResponderAdjective { get; set; }
        public Heroes Heroes { get; set; }

    }

    public enum Subject
    {
        [Display(Name = "I")]
        I,
        [Display(Name = "My wife and I")]
        WifeAndI,
        [Display(Name = "My husband and I")]
        HusbandAndI,
        [Display(Name = "We")]
        We
    }

    public enum Verb 
    { 
        [Display(Name = "hearbroken")]
        Heartbroken,
        [Display(Name = "devastated")]
        Devastated,
        [Display(Name = "horrified")]
        Horrified,
    }

    public enum Tragedy
    {
        [Display(Name = "senseless tragedy")]
        SenseLessTragedy,
        [Display(Name = "loss of life")]
        LossOfLife,
        [Display(Name = "shooting")]
        Shooting
    }

    public enum ThoughtPrayer
    {
        [Display(Name = "lifting up in prayer")]
        LiftingUp,
        [Display(Name = "praying for")]
        PrayingFor,
        [Display(Name = "offering thoughts and prayers")]
        OfferingThoughtsAndPrayers,
    }

    public enum SentenceObject
    {
        [Display(Name = "entire community")]
        Community,
        [Display(Name = "families effected")]
        FamiliesEffected,
        [Display(Name = "families of the victims")]
        FamiliesOfVictims,
        [Display(Name = "loved ones of the victims")]
        LovedOnes
    }

    public enum Adjective
    {
        [Display(Name = "heroic efforts")]
        Heroic,
        [Display(Name = "courageous efforts")]
        Courageous,
    }

    public enum Heroes
    {
        [Display(Name = "first responders")]
        FirstResponders,
        [Display(Name = "medical professionals")]
        MedicalPros,
        [Display(Name = "law enforcement")]
        LawEnforcement
    }

}

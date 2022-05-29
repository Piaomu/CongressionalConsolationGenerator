using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CongressionalConsolationGenerator.Models
{
    public class Condolence
    {
        public string Id { get; set; }
        public Subject SentenceSubject { get; set; }
        public Verb Verb1 { get; set; }
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

    public enum Year
    {
        [Display(Name = "2013")]
        Thirteen = 2013,
        [Display(Name = "2014")]
        Fourteen = 2014,
        [Display(Name = "2015")]
        Fifteen = 2015,
        [Display(Name = "2016")]
        Sixteen = 2016,
        [Display(Name = "2017")]
        Seventeen = 2017,
        [Display(Name = "2018")]
        Eighteen = 2018,
        [Display(Name = "2019")]
        Nineteen = 2019,
        [Display(Name = "2020")]
        Twenty = 2020,
        [Display(Name = "2021")]
        TwentyOne = 2021,
        [Display(Name = "2022")]
        TwentyTwo = 2022
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

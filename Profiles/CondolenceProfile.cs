using AutoMapper;
using CongressionalConsolationGenerator.Models;

namespace CongressionalConsolationGenerator.Profiles
{
    public class CondolenceProfile: Profile
    {
        public CondolenceProfile()
        {
            CreateMap<CondolenceInput, Condolence>();
        }
    }
}

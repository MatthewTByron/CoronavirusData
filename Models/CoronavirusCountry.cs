using System;

namespace CoronavirusData.Models
{
    public class CoronavirusCountry
    {
        public string CountryName { get; set; }
        public int CaseCount { get; set; }
        public string FlagUri { get; set; }
    }
}
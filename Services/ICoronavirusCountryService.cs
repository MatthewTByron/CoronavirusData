using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoronavirusData.Models;

namespace CoronavirusData.Services
{
    public interface ICoronavirusCountryService
    {
         Task<IEnumerable<CoronavirusCountry>> GetTopCases(int amountOfCountries);
    }
}
using CoronavirusData.Models;
using CoronavirusData.Services;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronavirusData.ViewModels
{
    public class CoronavirusCountiresChartViewModel
    {
        private const int AMOUNT_OF_COUNTRIES = 10;
        private readonly ICoronavirusCountryService _coronavirusCountryService;

        public ChartValues<int> CoronavirusCountryCaseCounts { get; set; }

        public string[] CoronavirusCountryNames { get; set; }

        public CoronavirusCountiresChartViewModel(ICoronavirusCountryService coronavirusCountryService)
        {
            _coronavirusCountryService = coronavirusCountryService;            
        }

        public static CoronavirusCountiresChartViewModel LoadViewModel(ICoronavirusCountryService coronavirusCountryService, Action<Task> onloaded = null)
        {
            CoronavirusCountiresChartViewModel viewModel = new CoronavirusCountiresChartViewModel(coronavirusCountryService);

            viewModel.Load().ContinueWith(t => onloaded?.Invoke(t));

            return viewModel;
        }

        public async Task Load()
        {
            IEnumerable<CoronavirusCountry> countries = await _coronavirusCountryService.GetTopCases(AMOUNT_OF_COUNTRIES);

            CoronavirusCountryCaseCounts = new ChartValues<int>(countries.Select(c => c.CaseCount));
            CoronavirusCountryNames = countries.Select(c => c.CountryName).ToArray();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using CoronavirusData.Services;
using CoronavirusData.Services.API;

namespace CoronavirusData.ViewModels
{
    public class MainViewModel
    {
        public CoronavirusCountiresChartViewModel CoronavirusCountiresChartViewModel { get; set; }
        public MainViewModel()
        {
            ICoronavirusCountryService coronavirusCountryService = new APICoronavirusCountryService();
            CoronavirusCountiresChartViewModel = CoronavirusCountiresChartViewModel.LoadViewModel(coronavirusCountryService);
        }
    }
    
}
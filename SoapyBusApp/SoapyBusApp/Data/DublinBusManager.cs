using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
/// <summary>
// Write a Xamarin.Android application of your choice.  The minimal requirements are outlined below:
//	Your app must make use of at least 3 UI screens (Use Tuts xamarin implicit styles)
//	Your app must make use of at least 1 external app and show clearly how the Intent IPC mechanism is being used.
//	Your app must make use of StartActivity() and StartActivityForResult().
//	Your app must have a persistent data model, e.g., using SQLLite or another persistent store.
/// </summary>
namespace SoapyBusApp
{
    class DublinBusManager
    {
        ISoapService soapService;

        public DublinBusManager(ISoapService service)
        {
            soapService = service;
        }
        public Task<List<DBItem>> GetBusStopDataAsync();
        {
            return ISoapService
    }
}



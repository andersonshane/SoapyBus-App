using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SoapyBusApp
{
    class DublinBusASMX : Application
    {
        public static DublinBusManager DBManager { get; set; }

        public App ()
        {
            MainPage = new NavigationPage(new (DBItemListPage));
        }
    
    protected overide void OnStart()
}

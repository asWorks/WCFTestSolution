using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibServiceConfiguration.Contracts;
using LibServiceConfiguration.Interfaces;
using System.IO;

namespace LibServiceConfiguration.Services
{
    public class WCFService : IWCFServiceContract
    {
        public void CreateAddress(Adress _Adress)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\TestWCFService\\test.txt", true);
            file.WriteLine(DateTime.Now.ToShortDateString());
            file.WriteLine(DateTime.Now.ToLongTimeString());
            file.WriteLine(_Adress.PostalCode);
            file.WriteLine(_Adress.City);
            file.WriteLine(_Adress.Street);
            file.WriteLine(_Adress.StreetNumber);
                       
            file.WriteLine("-------------------------------------------------------------------");


            file.Close();
        }

        public string GetMessage()
        {
            return "Hello Meldung";
        }

    }
}

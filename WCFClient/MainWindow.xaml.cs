using LibServiceConfiguration.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WCFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NetTcpBinding binding = new NetTcpBinding();
        Uri addressServer = new Uri("net.tcp://localhost:6001/WCFService");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (ChannelFactory<IWCFServiceContract> factory = new ChannelFactory<IWCFServiceContract>("MyWCFClientHTTP"))
            {


                //factory.Credentials.Windows.ClientCredential.UserName = "TestVMGuester\asWorks";
                //factory.Credentials.Windows.ClientCredential.Password = "%%schieb2Dok123";

                IWCFServiceContract proxy = factory.CreateChannel();



                var ad = new LibServiceConfiguration.Contracts.Adress();
                ad.PostalCode = "23879";
                ad.Street = "Mühlenstraße";
                ad.StreetNumber = "35";
                ad.City = "Mölln";
                proxy.CreateAddress(ad);

                ad = new LibServiceConfiguration.Contracts.Adress();
                ad.PostalCode = "23879";
                ad.Street = "Feuergräfen Straße";
                ad.StreetNumber = "11";
                ad.City = "Mölln";
                proxy.CreateAddress(ad);

                var x = proxy.GetMessage();
                MessageBox.Show(x);

            }



        }

        private void SendAddress_Click(object sender, RoutedEventArgs e)
        {
            using (ChannelFactory<IWCFServiceContract> factory = new ChannelFactory<IWCFServiceContract>("MyWCFClientNetTcp"))
            {

                //factory.Credentials.Windows.ClientCredential.UserName = "TestVMGuester\asWorks";
                //factory.Credentials.Windows.ClientCredential.Password = "%%schieb2Dok123";

                //var x = factory.Credentials.UserName;
                //  x.UserName = "TestVMGuester\asWorks";
                //  x.Password = "%%schieb2Dok123";


                IWCFServiceContract proxy = factory.CreateChannel();

                var ad = new LibServiceConfiguration.Contracts.Adress();
                ad.PostalCode = "23879";
                ad.Street = "Wasserkrüger Weg";
                ad.StreetNumber = "109";
                ad.City = "Mölln";
                proxy.CreateAddress(ad);

                ad = new LibServiceConfiguration.Contracts.Adress();
                ad.PostalCode = "23879";
                ad.Street = "Hauptstrasse";
                ad.StreetNumber = "17";
                ad.City = "Mölln";
                proxy.CreateAddress(ad);


                MessageBox.Show("sent 2 addresses");

            }
        }
    }
}

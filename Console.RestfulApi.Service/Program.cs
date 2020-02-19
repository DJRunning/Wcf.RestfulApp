using Console.RestfulApi.Service.InterfaceEx;
using Console.RestfulApi.Service.ServiceEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Console.RestfulApi.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopingQueryService service = new ShopingQueryService();
            Uri address = new Uri("http://127.0.0.1:8081");
            WebServiceHost _serviceHost = new WebServiceHost(service, address);
            _serviceHost.Opened += Host_Opened;
            _serviceHost.Closed += Host_Closed;
            _serviceHost.Open();
        }

        private static void Host_Closed(object sender, EventArgs e)
        {
            System.Console.WriteLine("服务已关闭...");
        }

        private static void Host_Opened(object sender, EventArgs e)
        {
            System.Console.WriteLine("服务已开启...");
            System.Console.WriteLine("按任意键关闭服务");
            System.Console.ReadKey();
            WebServiceHost host = sender as WebServiceHost;
            host.Close();
        }
    }
}

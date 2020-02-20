using Console.RestfulApi.Service.ServiceEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using RestfulApi.Common.IServiceContract;
namespace Console.RestfulApi.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopingQueryService service = new ShopingQueryService();

            /*
             * 1.终结点有地址采用终结点地址(终结点，基地址不为空时，采用终结点地址)
               2.终结点无地址则采用基地址
             */
            #region 通过配置承载服务
            
            //ServiceHost host = new ServiceHost(typeof(ShopingQueryService));//1.创建ServiceHost对象,通过配置进行承载
            //host.Open();
            //System.Console.WriteLine("服务已开启...");
            //System.Console.ReadKey();
            //host.Close(); 
            #endregion

            #region 通过代码WebServiceHost承载服务
            Uri address = new Uri("http://127.0.0.1:8081/");
            WebServiceHost _serviceHost = new WebServiceHost(service, address);//宿主则负责公开终结点(地址、绑定以及契约)用来承载服务
            _serviceHost.Opened += Host_Opened;
            _serviceHost.Closed += Host_Closed;
            _serviceHost.Open();
            #endregion
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

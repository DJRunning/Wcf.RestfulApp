using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using RestfulApi.Common.IServiceContract;
using RestfulApi.Common.Models;
namespace Console.RestfulApi.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ChannelFactory<IShopingInfoQuery> channelFactory = new ChannelFactory<IShopingInfoQuery>("addressService"))
            {
                IShopingInfoQuery shoping = channelFactory.CreateChannel();
                Shop s = shoping.GetPrice("3");
                Shop ss = shoping.GetInfo(new QueryInfo() { Id = 4, Name = "牛奶" });
            
            }
        }
    }
}

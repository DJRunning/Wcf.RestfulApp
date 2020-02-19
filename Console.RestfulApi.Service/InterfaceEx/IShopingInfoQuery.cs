using Console.RestfulApi.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Console.RestfulApi.Service.InterfaceEx
{
    [ServiceContract(Name = "ShopingQueryService11")]
    interface IShopingInfoQuery
    {
        [OperationContract]
        [WebGet(UriTemplate ="ShopInfoQuery/{id}",BodyStyle =WebMessageBodyStyle.Bare,RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json)]
        Shop GetPrice(string id);


        [OperationContract]
        [WebInvoke(Method ="POST",UriTemplate = "ShopInfoQuery/queryInfo",BodyStyle =WebMessageBodyStyle.Bare,RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        Shop GetInfo(QueryInfo queryInfo);
    }
}

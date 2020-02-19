/*
* ==================================================================
*	Copyright (C) 2020
*
*	描述：ShopingQueryService
*
*	作者：DJ
*
*	版本：1.0
*
*	CLR 版本：4.0.30319.42000
*
*	创建时间：2020/2/19 17:42:18
*
* ==================================================================
*	
*	命名空间：Console.RestfulApi.Service.ServiceEx
*
*	类名：ShopingQueryService
*	
* ==================================================================
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.RestfulApi.Service.InterfaceEx;
using Console.RestfulApi.Service.Models;
using System.ServiceModel;
using System.ServiceModel.Activation;
namespace Console.RestfulApi.Service.ServiceEx
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,ConcurrencyMode = ConcurrencyMode.Single,IncludeExceptionDetailInFaults =true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ShopingQueryService : IShopingInfoQuery
    {
        public ShopingQueryService()
        {
            lst.Add(new Shop() { Id = 1, Name = "小米", Price = 50.0, Des = "小米的价格" });
            lst.Add(new Shop() { Id = 2, Name = "苹果", Price = 28.0, Des = "苹果的价格" });
            lst.Add(new Shop() { Id = 3, Name = "紫薯", Price = 5.0, Des = "紫薯的价格" });
            lst.Add(new Shop() { Id = 4, Name = "牛奶", Price = 8.0, Des = "牛奶的价格" });
            lst.Add(new Shop() { Id = 5, Name = "花生", Price = 12.0, Des = "花生的价格" });
        }
        public List<Shop> lst = new List<Shop>();
        
        public Shop GetInfo(QueryInfo queryInfo)
        {
            return lst.FirstOrDefault(x => x.Id == queryInfo.Id && x.Name ==queryInfo.Name);
        }

        public Shop GetPrice(string id)
        {
            return lst.FirstOrDefault(x => x.Id.ToString() == id);
        }
    }
}

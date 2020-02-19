/*
* ==================================================================
*	Copyright (C) 2020
*
*	描述：QueryInfo
*
*	作者：DJ
*
*	版本：1.0
*
*	CLR 版本：4.0.30319.42000
*
*	创建时间：2020/2/19 17:30:20
*
* ==================================================================
*	
*	命名空间：Console.RestfulApi.Service.Models
*
*	类名：QueryInfo
*	
* ==================================================================
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Console.RestfulApi.Service.Models
{
    [DataContract]
    public class QueryInfo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}

/*
* ==================================================================
*	Copyright (C) 2020
*
*	描述：Shop
*
*	作者：DJ
*
*	版本：1.0
*
*	CLR 版本：4.0.30319.42000
*
*	创建时间：2020/2/19 17:26:42
*
* ==================================================================
*	
*	命名空间：RestfulApi.Common.Models
*
*	类名：Shop
*	
* ==================================================================
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestfulApi.Common.Models
{
    [DataContract]
    public class Shop
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Des { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ProductShop.Models;

namespace ProductShop.DTOs.Export
{
    [XmlType("Users")]
    public class GetUserAndProductsDTO
    {
        [XmlElement("count")]
        public int Count { get; set; }


        [XmlArray("users")]
        public UserInfo[] Users { get; set; }
    }

    [XmlType("User")]
    public class UserInfo
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }


        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("age")]
        public int? Age { get; set; }

        public SoldProducts SoldProducts { get; set; }      
    }


    [XmlType("SoldProducts")]
    public class SoldProducts
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("products")]
        public SoldProductInfo[] Products { get; set; }
    }


    [XmlType("Product")]
    public class SoldProductInfo
    {
        [XmlElement("name")]
        public string Name { get; set; }


        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}

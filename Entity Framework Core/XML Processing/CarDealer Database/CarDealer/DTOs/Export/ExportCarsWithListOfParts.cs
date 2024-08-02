﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarDealer.DTOs.Export
{
    [XmlType("car")]
    public class ExportCarsWithListOfParts
    {
        [XmlAttribute("make")]
        public string Make { get; set; }


        [XmlAttribute("model")]
        public string Model { get; set; }


        [XmlAttribute("traveled-distance")]
        public long TraveledDistance { get; set; }


        [XmlArray("parts")]
        public ExportPartsDto[] Parts { get; set; }
    }
}

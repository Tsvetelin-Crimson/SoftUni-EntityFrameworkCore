﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.DataTransferObjects.Input
{
    [XmlType("Category")]
    public class CategoryInputModel
    {
        [XmlElement("name")]
        public string Name { get; set; }

    }
}
/*
 <Category>
        <name>Drugs</name>
    </Category>
 */

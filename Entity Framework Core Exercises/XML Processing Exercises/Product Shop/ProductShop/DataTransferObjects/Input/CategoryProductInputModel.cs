﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.DataTransferObjects.Input
{
    [XmlType("CategoryProduct")]
    public class CategoryProductInputModel
    {
        [XmlElement("CategoryId")]
        public int CategoryId { get; set; }

        [XmlElement("ProductId")]
        public int ProductId { get; set; }
    }
}
/*
 <CategoryProducts>
    <CategoryProduct>
        <CategoryId>4</CategoryId>
        <ProductId>1</ProductId>
    </CategoryProduct>
 */

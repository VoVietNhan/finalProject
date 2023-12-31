﻿using BusinessObject.Enum.EnumStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Dtos.ProductInfo
{
    public class ProductInfoViewModel
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid SizeId { get; set; }
        public Size.SizeViewModel Size { get; set; }
        public Guid ProductId { get; set; }
        public EnumStatus Status { get; set; }
    }
}

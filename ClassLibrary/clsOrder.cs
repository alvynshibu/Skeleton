﻿using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool DeliveryStatus { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerId { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
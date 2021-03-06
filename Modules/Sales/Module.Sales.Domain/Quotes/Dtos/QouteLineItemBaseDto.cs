﻿using System;

namespace Module.Sales.Domain.Qoutes
{
    public class QouteLineItemBaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
    }
}

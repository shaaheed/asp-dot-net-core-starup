﻿using Module.Systems.Entities;

namespace Module.Sales.Entities
{
    public class Tax : OrganizationCodeNameEntity
    {
        public float Rate { get; set; }
        public string Description { get; set; }
        public string TaxNumber { get; set; }
        public bool ShowTaxNumberOnInvoice { get; set; }
        public bool IsCompoundTax { get; set; }
    }
}

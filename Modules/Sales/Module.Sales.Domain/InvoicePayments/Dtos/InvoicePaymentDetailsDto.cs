﻿using Module.Sales.Domain.Contacts;
using System;

namespace Module.Sales.Domain.InvoicePayments
{
    public class InvoicePaymentDetailsDto
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public ContactDto Customer { get; set; }
        public decimal AmountDue { get; set; }
        public decimal Total { get; set; }
        public DateTimeOffset IssueDate { get; set; }
        public DateTimeOffset PaymentDueDate { get; set; }
    }
}

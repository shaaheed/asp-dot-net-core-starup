﻿using Msi.Domain.Abstractions;
using Msi.Utilities.Filter;
using System;

namespace Module.Sales.Domain
{
    public class GetInvoicePaymentsQuery : Query<PagedCollection<InvoicePaymentDto>>
    {
        public Guid InvoiceId { get; set; }
    }
}

﻿using System;

namespace Module.Sales.Domain
{
    public class UpdateInvoicePaymentCommand : CreateInvoicePaymentCommand
    {
        public Guid Id { get; set; }
    }
}

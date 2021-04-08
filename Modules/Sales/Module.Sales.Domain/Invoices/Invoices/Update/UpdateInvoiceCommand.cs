﻿using Msi.Mediator.Abstractions;
using System;

namespace Module.Sales.Domain
{
    public class UpdateInvoiceCommand : InvoiceRequestDto, ICommand<long>
    {
        public Guid Id { get; set; }
    }
}

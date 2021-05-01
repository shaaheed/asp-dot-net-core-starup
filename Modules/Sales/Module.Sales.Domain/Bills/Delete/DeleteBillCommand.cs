﻿using Msi.Mediator.Abstractions;
using System;

namespace Module.Sales.Domain
{
    public class DeleteBillCommand : ICommand<long>
    {
        public Guid Id { get; set; }
    }
}

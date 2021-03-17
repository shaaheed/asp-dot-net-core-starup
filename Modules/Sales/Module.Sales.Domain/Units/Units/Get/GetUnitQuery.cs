﻿using Msi.Mediator.Abstractions;
using System;

namespace Module.Sales.Domain.Units
{
    public class GetUnitQuery : IQuery<UnitDto>
    {
        public Guid Id { get; set; }
    }
}

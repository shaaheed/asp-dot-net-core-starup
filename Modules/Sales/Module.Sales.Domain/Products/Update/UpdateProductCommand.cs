﻿using Msi.Mediator.Abstractions;
using System;

namespace Module.Sales.Domain.Products
{
    public class UpdateProductCommand : ICommand<long>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsSale { get; set; }
        public bool IsBuy { get; set; }

        public Guid? CategoryId { get; set; }
        public Guid? ManufacturerId { get; set; }
        public Guid? UnitOfMeasurementId { get; set; }

        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }

        public DateTimeOffset? SupportStartDate { get; set; }
        public DateTimeOffset? SupportEndDate { get; set; }
    }
}
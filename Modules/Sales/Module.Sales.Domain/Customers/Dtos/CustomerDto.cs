﻿using System;

namespace Module.Sales.Domain.Customers
{
    public class CustomerDto 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Contact { get; set; }
    }
}
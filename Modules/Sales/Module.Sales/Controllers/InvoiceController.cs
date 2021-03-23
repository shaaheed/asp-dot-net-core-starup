﻿using Microsoft.AspNetCore.Mvc;
using Module.Sales.Domain.Invoices;
using System.Threading.Tasks;
using static Module.Sales.Common.Permissions;
using Msi.Web;
using System;
using Msi.Utilities.Filter;

namespace Module.Sales.Controllers
{
    [Route("api/invoices")]
    [ApiController]
    [ETag]
    public class InvoiceController : BaseController
    {

        [HttpPost]
        //[RequirePermission(InvoiceCreate, InvoiceManage)]
        public async Task<IActionResult> Post([FromBody] CreateInvoiceCommand command)
        {
            var result = await OkAsync(command);
            return result.ToCreatedResult();
        }

        [HttpPut("{id}")]
        //[RequirePermission(InvoiceUpdate, InvoiceManage)]
        public Task<IActionResult> Put(Guid id, [FromBody] UpdateInvoiceCommand command)
        {
            command.Id = id;
            return OkAsync(command);
        }

        [HttpDelete("{id}")]
        //[RequirePermission(InvoiceDelete, InvoiceManage)]
        public Task<IActionResult> Delete([FromRoute] DeleteInvoiceCommand command)
        {
            return DeleteAsync(command);
        }

        [HttpGet]
        //[RequirePermission(InvoiceList, InvoiceManage)]
        public Task<IActionResult> Gets([FromQuery] SearchOptions searchOptions, [FromQuery] PagingOptions pagingOptions)
        {
            var query = new GetInvoicesQuery
            {
                PagingOptions = pagingOptions,
                SearchOptions = searchOptions
            };
            return OkAsync(query);
        }

        [HttpGet("{id}")]
        //[RequirePermission(InvoiceView, InvoiceManage)]
        public Task<IActionResult> Get([FromRoute] GetInvoiceQuery query)
        {
            return OkAsync(query);
        }
    }
}

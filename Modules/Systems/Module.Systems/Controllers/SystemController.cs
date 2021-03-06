﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Module.Systems.Services;
using Msi.Mediator.Abstractions;
using System.Threading.Tasks;

namespace Module.Systems.Controllers
{
    public class SystemController : ControllerBase
    {
        protected readonly ICommandBus _commandBus;
        protected readonly IQueryBus _queryBus;
        protected readonly ICacheService _cacheService;

        public SystemController()
        {
            _commandBus = HttpContext?.RequestServices?.GetService<ICommandBus>();
            _queryBus = HttpContext?.RequestServices?.GetService<IQueryBus>();
            _cacheService = HttpContext?.RequestServices?.GetService<ICacheService>();
        }

        public async Task<ActionResult> SendQueryAsync<T>(IQuery<T> query)
        {
            var result = await _cacheService.GetData(async () =>
            {
                var products = await _queryBus.SendAsync(query);
                return products;
            });

            if (result.Item1)
            {
                return new StatusCodeResult(304);
            }
            else
            {
                return new OkObjectResult(result.Item1);
            }
        }


    }
}

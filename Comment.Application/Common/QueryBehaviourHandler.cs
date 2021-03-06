﻿using Msi.Mediator.Abstractions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Comment.Application.Common
{
    public class QueryBehaviourHandler<TRequest, TResponse> : IQueryBehaviour<TResponse, TResponse>
    {
        public async Task<TResponse> Handle(TResponse request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            // before
            var response = await next();
            // after
            return response;
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Module.Systems.Filters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}

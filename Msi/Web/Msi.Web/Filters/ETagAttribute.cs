﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Msi.Web
{
    public class ETagAttribute : Attribute, IAsyncActionFilter
    {
        private readonly int[] _statusCodes;

        public ETagAttribute(params int[] statusCodes)
        {
            _statusCodes = statusCodes;
            if (statusCodes.Length == 0) _statusCodes = new[] { 200 };
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var result = await next();
            if (context.HttpContext.Request.Method == "GET")
            {
                if (_statusCodes.Contains(context.HttpContext.Response.StatusCode))
                {
                    //I just serialize the result to JSON, could do something less costly
                    var content = JsonConvert.SerializeObject(result.Result);

                    var etag = ETagGenerator.GetETag(context.HttpContext.Request.Path.ToString(), Encoding.UTF8.GetBytes(content));

                    if (context.HttpContext.Request.Headers.Keys.Contains("If-None-Match") && context.HttpContext.Request.Headers["If-None-Match"].ToString() == etag)
                    {
                        context.Result = new ObjectResult(context.ModelState)
                        {
                            Value = null,
                            StatusCode = 304
                        };
                    }
                    context.HttpContext.Response.Headers.Add("ETag", new[] { etag });
                }
            }
        }
    }

    // Helper class that generates the etag from a key (route) and content (response)
    public static class ETagGenerator
    {
        public static string GetETag(string key, byte[] contentBytes)
        {
            var keyBytes = Encoding.UTF8.GetBytes(key);
            var combinedBytes = Combine(keyBytes, contentBytes);

            return GenerateETag(combinedBytes);
        }

        private static string GenerateETag(byte[] data)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(data);
                string hex = BitConverter.ToString(hash);
                return hex.Replace("-", "");
            }
        }

        private static byte[] Combine(byte[] a, byte[] b)
        {
            byte[] c = new byte[a.Length + b.Length];
            Buffer.BlockCopy(a, 0, c, 0, a.Length);
            Buffer.BlockCopy(b, 0, c, a.Length, b.Length);
            return c;
        }
    }
}
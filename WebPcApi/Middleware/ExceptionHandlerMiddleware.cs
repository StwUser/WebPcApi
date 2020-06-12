using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPcApi.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private RequestDelegate _requestDelegate;

        private readonly ILogger<ExceptionHandlerMiddleware> _logger;

        public ExceptionHandlerMiddleware(RequestDelegate requestDelegate, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _requestDelegate = requestDelegate;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _requestDelegate.Invoke(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Log Excteption");
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Confitec.TestePratico.Service.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Confitec.TestePratico.App.Extensions
{
    public static class ErrorHandlerExtension
    {
        public static IApplicationBuilder UseErrorHandler(this IApplicationBuilder appBuilder)
        {
            return appBuilder.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    var exceptionHandlerFeature = context
                        .Features
                        .Get<IExceptionHandlerFeature>();

                    if (exceptionHandlerFeature != null)
                    {
                        context.Response.ContentType = "application/json";
                        var message = "Internal Server Error";

                        if (exceptionHandlerFeature.Error is NotFoundException)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                            message = exceptionHandlerFeature.Error.Message;
                        }
                        else
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        }

                        var json = new
                        {
                            context.Response.StatusCode,
                            Message = message,
                            Detail = exceptionHandlerFeature.Error.StackTrace,
                        };

                        await context.Response.WriteAsync(JsonConvert.SerializeObject(json));
                    }
                });
            });
        }
    }
}

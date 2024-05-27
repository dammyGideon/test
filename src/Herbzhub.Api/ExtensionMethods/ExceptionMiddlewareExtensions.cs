﻿using Herbzhub.Infrastructure.Helper;
using Herbzhub.Infrastructure.Interface;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace Herbzhub.Api.ExtensionMethods
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILoggerManager logger) {

            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if(contextFeature != null)
                    {
                        logger.LogError($"Something went wrong: {contextFeature.Error}");
                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode =context.Response.StatusCode,
                            Message = "Internal Server Error."
                        }.ToString());
                      
                    }
                });
            });
        }
    }
}

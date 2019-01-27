using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Mtn.ApiTemplate.Models;
using Mtn.ApiTemplate.Models.Enums;
using System.Net;
using Serilog;
using Serilog.Events;

namespace Mtn.ApiTemplate.Api
{
    public static class ErrorHandler
    {        
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
 
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if(contextFeature != null)
                    { 
                        Log.Error("Something went wrong: {error}", contextFeature.Error);
 
                        await context.Response.WriteAsync(new EventDetails
                        {
                            Type = EventDetailType.Error,
                            Message = "Internal Server Error."
                        }.ToString());
                    }
                });
            });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using log4net;

namespace ExceptionLogging.Models
{
    public class HandleExceptionAttribute:ExceptionFilterAttribute

    {
        private readonly ILoggerManager logger;

        public HandleExceptionAttribute()
        {
            this.logger = new LoggerManager();
        }
        public override void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomException" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(modelMetadata, context.ModelState);
            result.ViewData.Add("HandleException",context.Exception);
            context.Result = result;
            logger.LogInformation(context.Exception.Message.ToString());
            logger.LogInformation(context.Exception.StackTrace.ToString());
            context.ExceptionHandled = true;
            base.OnException(context);
        }
    }
}

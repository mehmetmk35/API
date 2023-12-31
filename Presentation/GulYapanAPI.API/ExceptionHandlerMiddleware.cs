

using GulYapanAPI.Infrastructure.ErrorLog;
using GulYapanAPI.Infrastructure.Logger;

namespace GulYapanAPI.API
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
   
         


        public ExceptionHandlerMiddleware(RequestDelegate Next)
        {
           
            next = Next;
           
        }

        public async Task Invoke(HttpContext httpContext)
        {
            ErrorLog IErrorLog =new ErrorLog();
            try
            {
                await next.Invoke(httpContext);

            }
            catch (Exception ex)
            {
                var desc = ex.StackTrace.Split("line")[0];
                IErrorLog.TextLog(ex.Message +"--" + desc);
                
            }

        }
    }
}

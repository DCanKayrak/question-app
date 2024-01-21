using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApi.Middleware
{
    public class HttpExceptionHandler
    {
        private HttpResponse response;

        public Task HandleExceptionAsync(Exception exception) => exception switch
        {
            _ => HandleException(exception)
        };

        public HttpResponse Response
        {
            get => response ?? throw new ArgumentNullException(nameof(response));
            set => response = value;
        }

        protected Task HandleException(Exception exception)
        {
            Response.StatusCode = StatusCodes.Status400BadRequest;
            string details = "Hata";
            return Response.WriteAsync(details);
        }
    }
}

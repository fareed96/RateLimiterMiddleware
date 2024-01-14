using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace RateLimiterMiddleware
{
    public class RateLimiter
    {
        private readonly RequestDelegate _next;
        private static readonly Dictionary<string, int> _requestCounts = new Dictionary<string, int>();

        public RateLimiter(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var ipAddress = context.Connection.RemoteIpAddress?.ToString();
            if (ipAddress == null)
            {
                await _next(context);
                return;
            }

            if (!_requestCounts.ContainsKey(ipAddress))
            {
                _requestCounts[ipAddress] = 1;
            }
            else
            {
                _requestCounts[ipAddress]++;
            

            if (_requestCounts[ipAddress] > 100) // Limit Rate
            {
                context.Response.StatusCode = 429; // Too Many Requests
                return;
            }

            await _next(context);
        }
    }

}
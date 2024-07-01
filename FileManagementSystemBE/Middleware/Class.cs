namespace FileManagementSystemBE.Middleware
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _next;
        public TestMiddleware(RequestDelegate next) { 
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("1.1");
            await _next(context);
            Console.WriteLine("1.2");
            await _next(context);
            Console.WriteLine("1.3");

        }
    }
    public class TestMiddleware2
    {
        private readonly RequestDelegate _next;
        public TestMiddleware2(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("2.1");
            await _next(context);
            Console.WriteLine("2.2");
            await _next(context);
            Console.WriteLine("3.3");
        }
    }
    public class TestMiddleware3
    {
        private readonly RequestDelegate _next;
        public TestMiddleware3(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("3.1");
            await _next(context);
            Console.WriteLine("3.2");
            await _next(context);
            Console.WriteLine("3.3");
        }
    }
}

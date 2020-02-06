using Sitecore.Pipelines.HttpRequest;

namespace DJDP.HelloWorld
{
    public class HelloWorldHeader: HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            args.HttpContext.Response.Headers.Add("X-DOCKER-HEADER", "Hello World");
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace GetContacts.Function
{
    public class GetContactsHttpTrigger
    {
        private readonly ILogger<GetContactsHttpTrigger> _logger;

        public GetContactsHttpTrigger(ILogger<GetContactsHttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("GetContactsHttpTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        } 
    }
}

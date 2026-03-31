using BDF.DVDCentral.BL.Models;
using FVTC.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BDF.DVDCentral.AzFunctions;

public class Function1
{
    private readonly ILogger<Function1> _logger;

    public Function1(ILogger<Function1> logger)
    {
        _logger = logger;
    }

    [Function("InsertDirector")]
    public async Task<IActionResult> Run1([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("Insert Directors");

        ApiClient apiClient = new ApiClient("https://fvtcdp.azurewebsites.net/api/Director");

        var result = apiClient.Authenticate("bfoote", "maple11");

        Director entity = new Director { FirstName = "Chris", LastName = "Mantheny" };

        var response = apiClient.Post<Director>(entity, "Director");
        var results = response.Content.ReadAsStringAsync().Result;

        return new OkObjectResult(results.ToString());
    }

    [Function("Function1")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
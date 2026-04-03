using BDF.DVDCentral.BL.Models;
using FVTC.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace BDF.DVDCentral.AzFunctions;

public class GenreFunctions
{
    private readonly ILogger<GenreFunctions> _logger;

    public GenreFunctions(ILogger<GenreFunctions> logger)
    {
        _logger = logger;
    }

    [Function("Function1")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }

    [Function("MakeGenre")]
    public string Run2([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
    {
        // Get the new genre
        string name = req.Query["name"];
        _logger.LogWarning($"Trying to add {name}");

        ApiClient apiClient = new ApiClient("https://fvtcdp.azurewebsites.net/api/Genre");
        var result = apiClient.Authenticate("bfoote", "maple");
        Genre genre = new Genre { Description = name! };
        var response = apiClient.Post<Genre>(genre, "Genre");
        string result1 = response.Content.ReadAsStringAsync().Result;
        _logger.LogWarning($"{result1}");
        return $"Added {name}: {result1}.";
    }

    [Function("GetGenres")]
    public IActionResult Run3([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
    {
        _logger.LogInformation("Get Genres");

        ApiClient apiClient = new ApiClient("https://fvtcdp.azurewebsites.net/api/Director");
        var result = apiClient.Authenticate("bfoote", "maple");
        var list = apiClient.GetList<Genre>();

        foreach (var entity in list)
        {
            _logger.LogWarning($"{entity.Description}");
        }
        var response1 = req.CreateResponse(HttpStatusCode.OK);
        response1.Headers.Add("Content-Type", "application/json; charset=utf-8");
        //response1.WriteAsJsonAsync(new StringContent(jsonToReturn, Encoding.UTF8, "application/json"));
        return new OkObjectResult(list);
    }
}
using BDF.DVDCentral.BL.Models;
using FVTC.Utility;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;
using System.Text;
//using Microsoft.AspNetCore.Mvc;

namespace BDF.DVDCentral.AzFunction
{
    public class Function1
    {
        private readonly ILogger _logger;

        public Function1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
        }

        [Function("MakeGenre")]
        public string Run1([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            // Get the new genre
            string name = req.Query["name"];
            _logger.LogWarning($"Trying to add {name}");

            ApiClient apiClient = new ApiClient("https://fvtcdp.azurewebsites.net/api/Genre");
            var result = apiClient.Authenticate("bfoote", "maple");
            Genre genre = new Genre { Description = name! };
            var response = apiClient.Post<Genre>(genre, "Genre");
            string result1 = response.Content.ReadAsStringAsync().Result;
            //return new OkObjectResult($"Added {name}: {result1}.");
            _logger.LogWarning($"{result1}");
            return $"Added {name}: {result1}.";
        }

        [Function("GetDirectors")]
        public List<Director> Run2([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("Get Directors");

            ApiClient apiClient = new ApiClient("https://fvtcdp.azurewebsites.net/api/Director");
            var result = apiClient.Authenticate("bfoote", "maple");
            var list = apiClient.GetList<Director>();
            
            foreach (var entity in list)
            {
                _logger.LogWarning($"{entity.FullName}");
            }
            var response1 = req.CreateResponse(HttpStatusCode.OK);
            response1.Headers.Add("Content-Type", "application/json; charset=utf-8");
            //response1.WriteAsJsonAsync(new StringContent(jsonToReturn, Encoding.UTF8, "application/json"));
            return list;    
        }


        [Function("Function1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}

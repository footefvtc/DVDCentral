using BDF.DVDCentral.BL.Models;
using BDF.DVDCentrol.UIConsole;
using FVTC.Utility;
using Newtonsoft.Json.Linq;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
    //  7RIxuUtP7yfhpWiqgrC51mSoosSp4yx3HyVBcJYepJdWrEU4cpYrJQQJ99CCACYeBjFXJ3w3AAABACOGaru8
    //  https://ai-120212964-again.openai.azure.com/
    //  https://ai-120212964-again.openai.azure.com/openai/deployments/gpt-4.1-mini/chat/completions?api-version=2025-01-01-preview

        string user = "Brian F.";
        List<int> pickedNumbers = new List<int>();
        string apiAddress = "https://localhost:7156/api/";
        //apiAddress = "https://dvdcentralapi-120212964.azurewebsites.net/api/";
        ApiClient apiClient = new ApiClient(apiAddress);

        string hubAddress = "https://fvtcdp.azurewebsites.net/BingoHub";
        //hubAddress = "https://localhost:7156/dvdcentralhub";


        try
        {
            string operation = DrawMenu();
            var signalRClient = new SignalRClient(hubAddress);

            while (operation != "x")
            {
                switch (operation)
                {
                    case "a":
                        try
                        {
                            var result = apiClient.Authenticate("bfoote", "maple1");
                            Console.WriteLine($"Authenticate: {result}");
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine($"Authenticate failed: {ex.Message}");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case "b":
                        try
                        {
                            var result = apiClient.Authenticate("bfoote", "maple");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine();
                            Console.WriteLine($"Authenticate: {result}");
                            Console.WriteLine($"Token: {apiClient.Token}");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine($"Authenticate failed: {ex.Message}");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case "c":
                        signalRClient.ConnectToChannel(user);
                        break;
                    case "d":
                        getDirectors(apiClient);
                        break;
                    case "g":
                        getGenres(apiClient);
                        break;
                    case "k":
                        KeyVaultClient.GetSecret("Connection-String-Prod");
                        break;
                    case "m":
                        getMovies(apiClient);
                        break;
                    case "n":
                        string nextNumber = SendNumberToBingoChannel(pickedNumbers);
                        signalRClient.SendMessageToChannel("Caller", nextNumber);
                        break;
                    case "o":
                        signalRClient.SendMessageToChannel(user, "Salad");
                        break;
                    case "s":
                        Console.WriteLine("Message?");
                        string message = Console.ReadLine();
                        signalRClient.SendMessageToChannel(user, message);
                        break;
                    case "p":
                        Console.WriteLine(InvokeSummarizeWithCopilotAsync());
                        break;
                    case "t":
                        Console.WriteLine(InvokeGetNextMoveFromCopilotAsync("E|X|O|X|E|E|O|E|E"));
                        break;
                    case "x":
                        break;

                }
                operation = DrawMenu();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }

    

    private static void getGenres(ApiClient apiClient)
    {
        getEntities<Genre>(apiClient, "Description");
    }

    private static string DrawMenu()
    {

        Console.WriteLine("Which operation do you wish to perform?");
        Console.WriteLine("Authenticate Fail (a)");
        Console.WriteLine("Authenticate Success (b)");
        Console.WriteLine("Connect to the Hub (c)");
        Console.WriteLine("Get Directors (d)");
        Console.WriteLine("Get Genres (g)");
        Console.WriteLine("Get Secret (k)");
        Console.WriteLine("Get Movies (m)");
        Console.WriteLine("New Number (n)");
        Console.WriteLine("Order a Salad (o)");
        Console.WriteLine("Summarize with copilot (p)");
        Console.WriteLine("Send a Message (s)");
        Console.WriteLine("Get next move from copilot (t)");
        Console.WriteLine("Exit (x)");

        string operation = Console.ReadLine();
        return operation;
    }

    private static void getDirectors(ApiClient apiClient)
    {
        getEntities<Director>(apiClient, "FullName");
    }

    private static void getMovies(ApiClient apiClient)
    {
        getEntities<Movie>(apiClient, "Title");
    }

    public static string SendNumberToBingoChannel(List<int> pickedNumbers)
    {
        int newnumber;
        Random generator = new Random();

        do
        {
            newnumber = generator.Next(1, 76);
        }
        while (pickedNumbers.Any(n => n == newnumber) && pickedNumbers.Count < 75);

        pickedNumbers.Add(newnumber);

        string message = newnumber.ToString();
        Console.WriteLine("Sending: " + message);
        return newnumber.ToString();
       
    }

    private static void getEntities<T>(ApiClient apiclient, string displayField)
    {
        try
        {
            var entities = apiclient.GetList<T>(typeof(T).Name);
            entities.ForEach(e => Console.WriteLine(e?.GetType().GetProperty(displayField)?.GetValue(e, null)?.ToString()));
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public static string InvokeGetNextMoveFromCopilotAsync(
                string gamestate = "E|X|O|X|E|E|O|E|E")
    {
        gamestate = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR";
        //gamestate = "r1bk3r/p2pBpNp/n4n2/1p1NP2P/6P1/3P4/P1P1K3/q5b1";
        string apiKey = "3Kfy8AtfW2w2DSfJEtQlmguqG6rpzvZWVB1auzGZpnPs2ovt0WlOJQQJ99BJACYeBjFXJ3w3AAABACOGQ2wd";
        string endpoint = "https://instructional.openai.azure.com/openai/deployments/gpt-5-mini/chat/completions?api-version=2025-01-01-preview";

        var requestBody = new
        {
            messages = new[]
            {
                new { role = "system", content = "You are a helpful assistant returns the next move for a chess board." },
                new { role = "user", content = $"Return the next move and new board : {gamestate}" }
            }
        };

        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("api-key", apiKey);

        var jsonBody = JObject.FromObject(requestBody).ToString();
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        var response = httpClient.PostAsync(endpoint, content);
        var responseString = response.Result.Content.ReadAsStringAsync();
        var jsonResponse = JObject.Parse(responseString.Result);

        string? summary = jsonResponse["choices"]?[0]?["message"]?["content"]?.ToString();
        Console.WriteLine("New: " + summary);

        requestBody = new
        {
            messages = new[]
            {
                new { role = "system", content = "You are a helpful assistant returns the next move for a chess board." },
                new { role = "user", content = $"draw this chess board in Ascii : {gamestate}" }
            }
        };
        httpClient.DefaultRequestHeaders.Add("api-key", apiKey);

        jsonBody = JObject.FromObject(requestBody).ToString();
        content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        response = httpClient.PostAsync(endpoint, content);
        responseString = response.Result.Content.ReadAsStringAsync();
        jsonResponse = JObject.Parse(responseString.Result);
        summary = jsonResponse["choices"]?[0]?["message"]?["content"]?.ToString();
        return summary + " for " + gamestate;
    }

    public static string InvokeSummarizeWithCopilotAsync(
       string logFile = @"C:\Projects\10152125-1-2025fall\Lee, Kristy\DVDCentral\DVDCentral-Transcript.log",
       string inputText = "Error: DeleteTest : Divide by zero.")
    {
        string logFileContent = null;

        if (File.Exists(logFile))
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Using log file: {logFile}");
            Console.ResetColor();
            logFileContent = File.ReadAllTextAsync(logFile).Result;
        }

        if (string.IsNullOrWhiteSpace(inputText) && string.IsNullOrWhiteSpace(logFileContent))
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("No input text or log file content provided. Exiting.");
            Console.ResetColor();
            return null;
        }

        if (!string.IsNullOrWhiteSpace(logFileContent))
        {
            inputText = logFileContent;
        }

        string apiKey = "3Kfy8AtfW2w2DSfJEtQlmguqG6rpzvZWVB1auzGZpnPs2ovt0WlOJQQJ99BJACYeBjFXJ3w3AAABACOGQ2wd";
        string endpoint = "https://instructional.openai.azure.com/openai/deployments/gpt-5-mini/chat/completions?api-version=2025-01-01-preview";

        var requestBody = new
        {
            messages = new[]
            {
                new { role = "system", content = "You are a helpful assistant that summarizes technical logs." },
                new { role = "user", content = $"Summarize this log: {inputText}" }
            }
        };

        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("api-key", apiKey);

        var jsonBody = JObject.FromObject(requestBody).ToString();
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        var response = httpClient.PostAsync(endpoint, content);
        var responseString = response.Result.Content.ReadAsStringAsync();
        var jsonResponse = JObject.Parse(responseString.Result);

        string summary = jsonResponse["choices"]?[0]?["message"]?["content"]?.ToString();
        return summary;
    }
}
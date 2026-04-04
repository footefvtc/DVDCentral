using BDF.DVDCentral.BL.Models;
using BDF.DVDCentrol.UIConsole;
using FVTC.Utility;

internal class Program
{
    private static void Main(string[] args)
    {

        string user = "Brian F.";
        List<int> pickedNumbers = new List<int>();
        string apiAddress = "https://localhost:7156/api/";
        string functionAddress = "http://localhost:7074/api/";
        //apiAddress = "https://dvdcentralapi-120212964.azurewebsites.net/api/";
        ApiClient apiClient = new ApiClient(functionAddress);

        string hubAddress = "https://fvtcdp.azurewebsites.net/BingoHub";
        hubAddress = "https://dvdcentralapi-120212964.azurewebsites.net/DVDCentralHub";
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
                    case "f":
                        getGenres(apiClient);
                        break;
                    case "g":
                        getGenres(apiClient);
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
        try
        {
            getEntities<Genre>(apiClient, "Description");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }

    private static string DrawMenu()
    {

        Console.WriteLine("Which operation do you wish to perform?");
        Console.WriteLine("Authenticate Fail (a)");
        Console.WriteLine("Authenticate Success (b)");
        Console.WriteLine("Connect to the Hub (c)");
        Console.WriteLine("Get Directors (d)");
        Console.WriteLine("Get Genres via Function (f)");
        Console.WriteLine("Get Genres (g)");
        Console.WriteLine("Get Movies (m)");
        Console.WriteLine("New Number (n)");
        Console.WriteLine("Order a Salad (o)");
        Console.WriteLine("Send a Message (s)");
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
            var entities = apiclient.GetList<T>();
            entities.ForEach(e => Console.WriteLine(e?.GetType().GetProperty(displayField)?.GetValue(e, null)?.ToString()));
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

}
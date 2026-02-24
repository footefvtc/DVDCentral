using BDF.DVDCentral.BL.Models;
using BDF.DVDCentrol.UIConsole;
using FVTC.Utility;

internal class Program
{
    private static void Main(string[] args)
    {

        string user = "Brian F.";
        string apiAddress = "https://localhost:7156/api/";
        //apiAddress = "https://dvdcentralapi-120212964.azurewebsites.net/api/";
        ApiClient apiClient = new ApiClient(apiAddress);

        string hubAddress = "https://fvtcdp.azurewebsites.net/BingoHub";


        try
        {
            string operation = DrawMenu();
            var signalRClient = new SignalRClient(hubAddress);

            while (operation != "x")
            {
                switch (operation)
                {
                    case "a":
                        break;
                    case "b":
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
                    case "m":
                        getMovies(apiClient);
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
        getEntities<Genre>(apiClient, "Description");
    }

    private static string DrawMenu()
    {

        Console.WriteLine("Which operation do you wish to perform?");
        Console.WriteLine("Connect to the Hub (c)");
        Console.WriteLine("Get Directors (d)");
        Console.WriteLine("Get Genres (g)");
        Console.WriteLine("Get Movies (m)");
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

}
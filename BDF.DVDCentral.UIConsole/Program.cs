using BDF.DVDCentral.BL.Models;
using FVTC.Utility;

internal class Program
{
    private static void Main(string[] args)
    {

        string user = "Brian F.";
        string apiAddress = "https://localhost:7156/api/";
        //apiAddress = "https://dvdcentralapi-120212964.azurewebsites.net/api/";
        ApiClient apiClient = new ApiClient(apiAddress);


        try
        {
            string operation = DrawMenu();

            while (operation != "x")
            {
                switch (operation)
                {
                    case "a":
                        break;
                    case "b":
                        break;
                    case "c":
                        break;
                    case "d":
                        getDirectors(apiClient);
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



    private static string DrawMenu()
    {

        Console.WriteLine("Which operation do you wish to perform?");
        Console.WriteLine("Get Directors (d)");
        Console.WriteLine("Exit (x)");

        string operation = Console.ReadLine();
        return operation;
    }

    private static void getDirectors(ApiClient apiClient)
    {
        getEntities<Director>(apiClient, "FullName");
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
using System;
using System.Threading.Tasks;
class AsyncAwaitDemo
{
    public static async Task<string> fetchDataAsync()
    {
        await Task.Delay(2000);
        return "data fetched";
    }

    public static async Task processDataAsync()
    {
        try
        {
            string Data = await fetchDataAsync();
            Console.WriteLine(Data);
        }
        catch (Exception ex)
        {
            Console.WriteLine("error: " + ex.Message);
        }
    }

    public async static Task Main(string[] args)
    {
        Console.WriteLine("starting async operations...");
        await processDataAsync();
        Console.WriteLine("async operations completed.");
    }
}

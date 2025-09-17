using system;
class asyncawait
{
    public async task<string> fetchDataAsync()
    {
        await task.delay(2000);
        return "data fetched";
    }

    public async task processDataAsync()
    {
        try
        {
            string Data = await fetchDataAsync();
            ConsoleWriteLine(Data);
        }
        catch (exception ex)
        {
            ConsoleWriteLine("error: " + ex.message);
        }
    }

    public async task main(string[] args)
    {
        ConsoleWriteLine("starting async operations...");
        await processDataAsync();
        ConsoleWriteLine("async operations completed.");
    }
}

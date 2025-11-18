public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public void Dissplay()
    {
      Console.WriteLine($"Prompt: {_prompt} ");
      Console.WriteLine($"Response: {_response} ");
      Console.WriteLine($"Date: {_date} ");  
    }
}
public class MachineLogger : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine("LOG: " + message);
        File.AppendAllText("vending_log.txt", message + Environment.NewLine);
    }
}

public class StateObserver : IObserver
{
    private readonly Label _label;

    public StateObserver(Label label)
    {
        _label = label;
    }

    public void Update(string message)
    {
        if (message.StartsWith("State changed"))
        {
            _label.Invoke((Action)(() =>
            {
                _label.Text = $"State: {message.Split(':')[1].Trim()}";
                _label.ForeColor = message.Contains("WaitingState") ? Color.Red : Color.Green;
            }));
        }
    }
}
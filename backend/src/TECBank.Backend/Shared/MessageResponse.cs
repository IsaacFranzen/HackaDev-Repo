namespace TECBank.Backend.Shared;

public class MessageResponse
{
    public MessageResponse(string message)
    {
        Message = message;
        Moment = DateTimeOffset.Now;
    }

    public MessageResponse(string message, DateTimeOffset moment)
    {
        Message = message;
        Moment = moment;
    }

    public string Message { get; private set; }
    public DateTimeOffset Moment { get; private set; }
}

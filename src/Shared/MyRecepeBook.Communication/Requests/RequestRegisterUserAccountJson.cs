namespace MyRecepeBook.Communication.Requests;

public class RequestRegisterUserAccountJson
{
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
}

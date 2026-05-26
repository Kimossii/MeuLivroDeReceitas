using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyRecepeBook.Exception.ExceptionsBase;

public class ErrorOnValidationException : MyReceoeBookException
{
    private readonly List<string> _errors;
    public ErrorOnValidationException(List<string> errorMessages)
    {
        _errors = errorMessages;
    }
}

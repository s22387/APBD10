namespace Solution.Exception;

public class InvalidTokenException : System.Exception 
{
    public InvalidTokenException(string message) : base(message) { }
    public InvalidTokenException() : base("") { }
}
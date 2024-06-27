namespace Solution.Exception;

public class InvalidPasswordException : System.Exception
{
    public InvalidPasswordException() : base("Invalid password") { }
}
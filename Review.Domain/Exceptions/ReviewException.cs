namespace Review.Domain.Exceptions;

public class ReviewException: Exception
{
    public ReviewException(string message) : base(message) { }
}
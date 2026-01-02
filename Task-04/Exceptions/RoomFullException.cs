namespace HospitalManagement.Exceptions;

public class RoomFullException : Exception
{
    public RoomFullException(string message) : base(message)
    {
    }
}

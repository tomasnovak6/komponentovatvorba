using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AvailableTotalException: AcountException
{
    private const string _message = "Nelze vybrat vice, nez je disponibilni castka.";

    public AvailableTotalException() : base(_message) { }

    public AvailableTotalException(string? message): base(_message) { 

    }

    public AvailableTotalException(string? message, Exception? innerException): base(message, innerException)
    {

    }
}

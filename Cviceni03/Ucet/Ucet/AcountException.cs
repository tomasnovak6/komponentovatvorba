using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AcountException: Exception
{
    public AcountException() { }

    public AcountException(string? message): base(message)
    {

    }

    public AcountException(string? message, Exception? innerException): base(message, innerException)
    {

    }
}

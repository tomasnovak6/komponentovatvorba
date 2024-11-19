using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


public class AmountException : AcountException
{
    private const string _message = "Castka musi  byt vetsi nez 0.";
    
    public AmountException(): base(_message) { }

    public AmountException(string? message): base(message)
    {

    }
    
    public AmountException(string? message, Exception? innerException): base(message, innerException)
    {

    }
}


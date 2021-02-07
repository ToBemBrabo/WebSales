using System;

namespace WebSales.Services.Exceptions
{
    public class NotFounException : ApplicationException
    {

        public NotFounException(string message) : base(message)
        {
        }

    }
}

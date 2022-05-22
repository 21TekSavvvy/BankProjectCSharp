using System;


namespace Bank.Exceptions
{
    /// <summary>
    /// Exception class that represents error raised in Customer class
    /// </summary>
    public class CustomerException: ApplicationException
    {
        /// <summary>
        /// Constructor that initializes  exception message
        /// </summary>
        /// <param name="message">exception message</param>
        public CustomerException( string message): base(message)
        {

        }
        public CustomerException
    }
}

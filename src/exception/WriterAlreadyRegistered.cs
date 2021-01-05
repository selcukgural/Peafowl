namespace Peafowl.Exception
{
    public class WriterAlreadyRegistered : System.Exception
    {
        public WriterAlreadyRegistered()
        {
            
        }

        public WriterAlreadyRegistered(string message):base(message)
        {
            
        }

        public WriterAlreadyRegistered(string message, System.Exception innerException):base(message, innerException)
        {
            
        }
    }
}

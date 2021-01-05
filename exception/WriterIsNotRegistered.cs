namespace Peafowl.Exception
{
    public class WriterIsNotRegistered : System.Exception
    {
        public WriterIsNotRegistered()
        {
            
        }

        public WriterIsNotRegistered(string message):base(message)
        {
            
        }

        public WriterIsNotRegistered(string message, System.Exception innerException):base(message,innerException)
        {
            
        }
    }
}

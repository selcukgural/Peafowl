using System;

namespace Peafowl
{
    public class ErrorWriter : Writer
    {
        public ErrorWriter()
        {
            this.ChangeForegroundColor(ConsoleColor.DarkRed);
        }
    }
}

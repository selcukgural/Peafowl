using System;

namespace Peafowl
{
    public class FatalWriter : Writer
    {
        public FatalWriter()
        {
            this.ChangeForegroundColor(ConsoleColor.Red);
        }
    }
}

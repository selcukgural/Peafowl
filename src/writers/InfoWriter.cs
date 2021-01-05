using System;

namespace Peafowl
{
    public class InfoWriter : Writer
    {
        public InfoWriter()
        {
            this.ChangeForegroundColor(ConsoleColor.Cyan);
        }
    }
}

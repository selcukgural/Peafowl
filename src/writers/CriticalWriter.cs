using System;

namespace Peafowl
{
    public class CriticalWriter : Writer
    {
        internal CriticalWriter()
        {
            this.ChangeForegroundColor(ConsoleColor.Yellow);
        }
    }
}
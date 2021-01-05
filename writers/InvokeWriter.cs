using System;

namespace Peafowl
{
    internal class InvokeWriter
    {
        private ConsoleColor _currentForegroundColor;
        private ConsoleColor _currentBackgroundColor;
        internal InvokeWriter BeforeWrite(ConsoleColor nfColor, ConsoleColor nbColor)
        {
            _currentForegroundColor = System.Console.ForegroundColor;
            _currentBackgroundColor = System.Console.BackgroundColor;

            System.Console.ForegroundColor = nfColor;
            System.Console.BackgroundColor = nbColor;

            return this;
        }

        internal InvokeWriter Write(string text)
        {
            System.Console.Write(text);
            return this;
        }

        internal InvokeWriter WriteLine(string text)
        {
            System.Console.WriteLine(text);
            return this;
        }
        internal void AfterWrite()
        {
            System.Console.ForegroundColor = _currentForegroundColor;
            System.Console.BackgroundColor = _currentBackgroundColor;
        }
    }
}
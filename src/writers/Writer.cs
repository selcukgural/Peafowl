using System;

namespace Peafowl
{
    public abstract class Writer
    {
        private readonly InvokeWriter _invokeWriter = new InvokeWriter();

        public ConsoleColor ForegroundColor { get; private set; } = System.Console.ForegroundColor;
        public ConsoleColor BackgroundColor { get; private set; } = System.Console.BackgroundColor;

        public void Write(string text)
        {
            _invokeWriter
                .BeforeWrite(ForegroundColor, BackgroundColor)
                .Write(text)
                .AfterWrite();
        }
        public void WriteLine(string text)
        {
            _invokeWriter
                .BeforeWrite(ForegroundColor, BackgroundColor)
                .WriteLine(text)
                .AfterWrite();
        }
        public void ChangeForegroundColor(ConsoleColor color)
        {
            ForegroundColor = color;
        }
        public void ChangeBackgroundColor(ConsoleColor color)
        {
            BackgroundColor = color;
        }
    }
}
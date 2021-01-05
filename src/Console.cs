using System.Collections.Concurrent;
using Peafowl.Exception;

namespace Peafowl
{
    public static class Console
    {
        #region Predefined Writers
        public static readonly Writer Info = new InfoWriter();
        public static readonly Writer Critical = new CriticalWriter();
        public static readonly Writer Error = new ErrorWriter();
        public static readonly Writer Fatal = new FatalWriter();
        #endregion

        #region User Defined Writers
        private static readonly ConcurrentDictionary<string, Writer> UserDefinedWriters =
            new ConcurrentDictionary<string, Writer>();
        #endregion

        public static void Register<T>(string name, T writer) where T : Writer,new()
        {
            if (UserDefinedWriters.ContainsKey(name))
                throw new WriterAlreadyRegistered($"This key ({nameof(name)}) already registered");

            if(!UserDefinedWriters.TryAdd(name, writer))
                throw new WriterAlreadyRegistered($"This key ({nameof(name)}) already registered");
        }

        public static T Get<T>(string name) where T : Writer,new()
        {
            if (!UserDefinedWriters.ContainsKey(name))
                throw new WriterIsNotRegistered($"This key ({nameof(name)}) is not registered.");

            if(!UserDefinedWriters.TryGetValue(name, out var writer))
                throw new WriterIsNotRegistered($"This key ({nameof(name)}) is not registered.");

            return (T)writer;
        }

        public static ConcurrentDictionary<string, Writer> GetRegisteredTypes()
        {
            return new ConcurrentDictionary<string, Writer>(UserDefinedWriters);
        }

        public static void ClearRegisteredTypes()
        {
            UserDefinedWriters.Clear();
        }
    }
}

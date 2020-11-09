using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.logging
{
    public abstract class AbstractLoggingManager : ITaxLoggingManager
    {
        private readonly Dictionary<Type, ITaxLogger> loggersPool = new Dictionary<Type, ITaxLogger>();
        public ITaxLogger createLogger(Type type)
        {
            ITaxLogger newLogger = createLogger(type);
            loggersPool.Add(type, newLogger);
            return newLogger;
        }

        public ITaxLogger getLogger(Type type)
        {
            return loggersPool.ContainsKey(type) ? loggersPool[type] : createLogger(type);
        }
    }
}

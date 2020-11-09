using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.logging
{
    public interface ITaxLoggingManager //extends EngineManager
    {
        ITaxLogger createLogger(Type type);

        ITaxLogger getLogger(Type type);
    }
}

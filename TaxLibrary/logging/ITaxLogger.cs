using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.logging
{
    public interface ITaxLogger
    {
        void Debug(String text);

        void Debug(String text, Exception e);

        void Debug(Exception e);

        void Info(String text);

        void Info(String text, Exception e);

        void Info(Exception e);

        void Warn(String text);

        void Warn(String text, Exception e);

        void Warn(Exception e);

        void Error(String text);

        void Error(String text, Exception e);

        void Error(Exception e);

        bool IsErrorEnabled();

        bool IsDebugEnabled();

        bool IsWarnEnabled();

        bool IsInfoEnabled();
    }
}

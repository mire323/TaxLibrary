using System;

namespace TaxLibrary.logging
{
    public interface ITaxLogger
    {
        void Debug(string text);

        void Debug(string text, Exception e);

        void Debug(Exception e);

        void Info(string text);

        void Info(string text, Exception e);

        void Info(Exception e);

        void Warn(string text);

        void Warn(string text, Exception e);

        void Warn(Exception e);

        void Error(string text);

        void Error(string text, Exception e);

        void Error(Exception e);

        bool IsErrorEnabled();

        bool IsDebugEnabled();

        bool IsWarnEnabled();

        bool IsInfoEnabled();
    }
}

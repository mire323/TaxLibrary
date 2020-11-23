using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Managers
{
    public interface IClipboardable
    {
        void ClipboardCopy();

        void ClipboardPaste();

        void ClipboardClear();

        void ClipboardAdd();

        Type GetClipboardManagerClass();
    }

}

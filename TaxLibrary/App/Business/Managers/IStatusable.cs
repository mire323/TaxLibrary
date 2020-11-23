using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Managers
{
    public interface IStatusable
    {
        void SetImmutable(bool immutable);

        void SetEditable(bool editable);

        void SetInsertable(bool insertable);

        void SetUpdateable(bool updateable);

        void SetDeletable(bool deletable);

        void SetAllDeletable(bool allDeletable);

        bool IsImmutable();

        bool IsEditable();

        bool IsInsertable();

        bool IsUpdateable();

        bool IsDeletable();

        bool IsAllDeletable();

        void SetClipboardEnabled(bool clipboardEnabled);

        bool IsClipboardEnabled();

        void SetClipboardClearEnabled(bool clipboardClearEnabled);

        bool IsClipboardClearEnabled();

        void SetClipboardCopyEnabled(bool clipboardCopyEnabled);

        bool IsClipboardCopyEnabled();

        void SetClipboardPasteEnabled(bool clipboardPasteEnabled);

        bool IsClipboardPasteEnabled();

        void SetClipboardAddEnabled(bool clipboardAddEnabled);

        bool IsClipboardAddEnabled();

    }
}

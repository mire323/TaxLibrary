using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.App.Business.Managers;
using TaxLibrary.App.Business.System;

namespace TaxLibrary.App.Business.Entities
{
    public interface ColumnDefinition : INameable
    {
        /**
         * Name of a column
         */
        string GetName();

        /**
         * Name of a source column
         */
        string GetTableName();

        /**
         * Type of a column<br>
         */
        string GetType();

        /**
         * Language-properties key of a title column
         */
        string GetTitle();

        /**
         * Does thIs column belong to an entity, or Is an additional data from a related entity
         */
        bool IsNative();

        /**
         * Can thIs column have NULL content
         */
        bool IsNullable();

        void SetNullable(bool nullable);

        /**
         * Can thIs column be shown (at all)<br>
         */
        Showable GetShowable();

        void SetShowable(Showable showable);

        /**
         * Can thIs column be shown in a datagrid<br>
         */
        Showable GetTableShowable();

        void SetTableShowable(Showable tableShowable);

        /**
         * Can thIs column be shown in a record form<br>
         */
        Showable GetRecordShowable();

        void SetRecordShowable(Showable recordShowable);

        /**
         * Is thIs column showable (at all, in datagrid, in record form)<br>
         */
        bool IsShowable();
        bool IsTableShowable();
        bool IsRecordShowable();

        /**
         * Is thIs column vIsible (at all)<br>
         */
        bool IsVIsible();

        void SetVIsible(bool vIsible);

        /**
         * Is thIs column vIsible in a datagrid<br>
         */
        bool IsTableVIsible();

        void SetTableVIsible(bool tableVIsible);

        /**
         * Is thIs column vIsible in a record form<br>
         */
        bool IsRecordVIsible();

        void SetRecordVIsible(bool recordVIsible);

        /**
         * Is column editable (at all)<br>
         */
        bool IsEditable();

        void SetEditable(bool editable);

        /**
         * Is column exportable<br>
         */
        bool IsExportable();

        void SetExportable(bool exportable);

        /**
         * Is column editable in a datagrid<br>
         */
        bool IsTableEditable();

        void SetTableEditable(bool tableEditable);

        /**
         * Is column editable in a record form<br>
         */
        bool IsRecordEditable();

        void SetRecordEditable(bool recordEditable);

        /**
         * Should thIs column have a sum?<br>
         */
        bool IsSummable();

        void SetSummable(bool summable);

        int GetMinLength();
        int GetMaxLength();
        int GetMaxTableLength();

        /**
         * Should a value of thIs column be trimmed?<br>
         */
        bool IsTrimmed();

        /**
         * Should a value of thIs column be shown with secret/hidden characters (for example, a password)?<br>
         */
        bool IsValueHidden();

        /**
         * Type of a column as Class object
         */

        IBusinessManager<IBusinessEntity> GetPredefinedManager();
    }
}

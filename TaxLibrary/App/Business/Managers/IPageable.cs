using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Managers
{
    public interface IPageable
    {
        int GetPageNumber();

        void SetPageNumber(int pageNumber);

        int GetPageSize();

        void SetPageSize(int pageSize);
    }
}

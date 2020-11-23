using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Actions
{
    public interface ActionInformation
    {
        bool IsEnabled();
        bool IsAvailable();
        string GetDescription();
        string GetExplanation();
    }

}

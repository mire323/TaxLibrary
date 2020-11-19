using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Actions
{
    public interface ITaxAction<ActionReturnType>
    {
        public string GetName();
        public string GetTitle();
        public TaxActionType GetActionType();
        public bool HasRightsOn();
        public bool IsEnabled();
        public bool IsAvailable();
        public string GetDescription();
        public string GetExplanation();
        public string GetSuccessDescription();
        public ActionReturnType Execute();
    }

}

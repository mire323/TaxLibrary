using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Actions
{
    public abstract class AbstractTaxAction<ActionReturnType> : ITaxAction<ActionReturnType>
    {
        public const string UNDEFINED_NAME = "Noname";

        private String name;
        private TaxActionType type;
        private String title;
        private String description;
        private String successDescription;

        public AbstractTaxAction(TaxActionType type) : base()
        {
            SetType(type);
            SetName(GetType().Name);
            SetTitle(GetType().Name + ".title");
            SetDescription(GetType().Name + ".description");
            SetSuccessDescription(GetType().Name + ".success");
        }

        protected void SetName(String name)
        {
            this.name = name ?? UNDEFINED_NAME;
        }

        private void SetType(TaxActionType type)
        {
            this.type = type != null ? type : TaxActionType.UNDEFINED;
        }

        protected void SetTitle(String title)
        {
            this.title = title ?? UNDEFINED_NAME;
        }

        protected void SetDescription(String description)
        {
            this.description = description ?? UNDEFINED_NAME;
        }

        protected void SetSuccessDescription(String successDescription)
        {
            this.successDescription = successDescription != null ? successDescription : UNDEFINED_NAME;
        }

        public TaxActionType GetActionType()
        {
            return type;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetSuccessDescription()
        {
            return successDescription;
        }

        public string GetExplanation()
        {
            return null;
        }

        public bool HasRightsOn()
        {
            return true;
        }

        public bool IsEnabled()
        {
            return true;
        }



        public ActionReturnType Execute()
        {
            throw new NotImplementedException();
        }

        public bool IsAvailable() => HasRightsOn() && IsEnabled();
    }
}

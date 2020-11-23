using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.App.Business.Entities;

namespace TaxLibrary.App.Business.Managers
{
    public class MasterRelation
    {
        private string columnName;
        private IBusinessEntity entity;

        public string ColumnName { get; set; }
        public IBusinessEntity Entity { get; set; }

        public MasterRelation(String columnName, IBusinessEntity entity) : base()
        {
            ColumnName = columnName;
            Entity = entity;
        }
    }
}
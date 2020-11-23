using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Filters
{
    public class TaxFilterItem
    {

        private string name;
        private TaxRelation relation = TaxRelation.EQUAL;
        private object value;
        public string Name { get; set; }
        public TaxRelation Relation { get; set; }
        public object Value { get; set; }

        public TaxFilterItem(string column, TaxRelation relation, object value)
        {
            SetValue(column, relation, value);
        }

        public TaxFilterItem(string column, object value) : this(column, TaxRelation.EQUAL, value)
        {

        }


        public TaxFilterItem(TaxFilterItem other) : this(other.Name, other.Relation, other.Value)
        {

        }

        public void SetValue(String columnName, TaxRelation relation, Object value)
        {
            this.name = columnName;
            this.relation = relation;
            this.value = value;
        }

        public void SetValue(string columnName, object value)
        {
            SetValue(columnName, TaxRelation.EQUAL, value);
        }
        public override string ToString()
        {
            return "(<" + name + ">" + relation + "<" + value + ">)";
        }
    }
}

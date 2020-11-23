using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Filters
{
    public class TaxFilter
    {
        private List<TaxFilterItem> items;

        public TaxFilter()
        {
            items = new List<TaxFilterItem>();
        }

        public int Size()
        {
            return items.Count;
        }

        public TaxFilter(params TaxFilterItem[] filterItems) : this()
        {
            if (filterItems == null) return;
            foreach (TaxFilterItem filterItem in filterItems)
            {
                if (filterItem != null) add(filterItem);
            }
        }

        public TaxFilter(TaxFilter filter) : this()
        {

            if (filter == null) return;
            for (int i = 0; i < filter.Size(); i++)
            {
                if (filter.GetItem(i) != null) add(filter.GetItem(i));
            }
        }

        public TaxFilter(string column, TaxRelation relation, object value) : this(new TaxFilterItem(column, relation, value))
        {

        }

        public TaxFilter(String column, Object value) : this(new TaxFilterItem(column, value))
        {

        }
        public TaxFilterItem GetItem(int i)
        {
            if (i < 0 || i >= items.Count) return null;
            return items[i];
        }

        public List<TaxFilterItem> GetItems()
        {
            return items;
        }
        public void Clear()
        {
            items.Clear();
        }

        // ukloni jednu filter-definiciju (ako se sadrzi u skupu)
        public void remove(TaxFilterItem filterItem)
        {
            if (filterItem == null) return;
            for (int i = 0; i < items.Count; i++)
            {
                if (filterItem.Equals(items[i]))
                {
                    items.RemoveAt(i);
                    return;
                }
            }
        }

        public void Remove(TaxFilter filter)
        {
            if (filter == null) return;
            for (int i = 0; i < filter.Size(); i++)
            {
                items.Remove(filter.GetItem(i));
            }
        }

        public TaxFilter add(TaxFilterItem filter)
        {
            if (filter != null)
            {
                items.Add(filter);
            }
            return this;
        }

        public TaxFilter Add(TaxFilter filter)
        {
            if (filter != null)
            {
                for (int i = 0; i < filter.Size(); i++)
                {
                    items.Add(filter.GetItem(i));
                }
            }
            return this;
        }

        // ---------------------------------------------------------------------------------
        // Metode za postavljanje novog filtera
        // ---------------------------------------------------------------------------------
        public void Set(TaxFilterItem filter)
        {
            Clear();
            add(filter);
        }

        public void Set(TaxFilter filter)
        {
            Clear();
            Add(filter);
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder("[");
            foreach (TaxFilterItem l in items)
            {
                s.Append(l);
            }
            s.Append("]");
            return s.ToString();
        }

        public void Copy(TaxFilter filter)
        {
            Clear();
            if (filter == null) return;

            for (int i = 0; i < filter.Size(); i++)
            {
                if (filter.GetItem(i) != null) add(filter.GetItem(i));
            }
        }
    }
}

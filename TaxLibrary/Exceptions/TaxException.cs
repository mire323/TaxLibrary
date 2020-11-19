using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TaxLibrary.exception
{
    public class TaxException : Exception
    {

        private readonly List<string> keys = new List<string>();

        public TaxException() : base()
        {
            AddKeys(GetType().Name);
        }

        public TaxException(params string[] keys) : base()
        {
            AddKeys(GetType().Name);
            AddKeys(keys);
        }

        public TaxException(Exception e) : base()
        {
            AddKeys(GetType().Name);
            AddKeys(e.Message);
        }

        public void SetKeys(params string[] keys)
        {
            ClearKeys();
            AddKeys(keys);
        }

        public void AddKeys(params string[] keys)
        {
            keys.ToList().ForEach(key => this.keys.Add(key));
        }

        public void ClearKeys()
        {
            keys.Clear();
        }

        public List<String> getKeys()
        {
            return keys;
        }


        public override string ToString()
        {
            return keys.ToList().Select(key => key + ":").ToString();
        }
    }
}
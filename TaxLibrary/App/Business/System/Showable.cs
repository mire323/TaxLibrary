using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.System
{
    public class Showable
    {


        public static readonly Showable NEVER = new Showable("never");
        public static readonly Showable USER_DEFINED = new Showable("userDefined");
        public static readonly Showable ALWAYS = new Showable("always");

        public static IEnumerable<Showable> Values
        {
            get
            {
                yield return NEVER;
                yield return USER_DEFINED;
                yield return ALWAYS;
            }
        }

        private string text;
        public string Text { get; private set; }

        Showable(string text) =>
            (Text) = (text);

        public override string ToString() => text;
        public static Showable Of(string text)
        {
            if (text == null)
            {
                return null;
            }

            foreach (Showable item in Values)
            {
                if (string.Equals(text, item.Text, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }
    }
}


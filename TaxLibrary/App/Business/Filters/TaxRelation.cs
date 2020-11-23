using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Filters
{
    public class TaxRelation
    {


        public static readonly TaxRelation NO_RELATION = new TaxRelation("NoRelation", "   ", StringOnly.NO);
        public static readonly TaxRelation CONTAINS = new TaxRelation("Contains", " %%", StringOnly.YES);
        public static readonly TaxRelation STARTS_WITH = new TaxRelation("StartsWith", " %=", StringOnly.YES);
        public static readonly TaxRelation ENDS_WITH = new TaxRelation("EndsWith", " =%", StringOnly.YES);
        public static readonly TaxRelation EQUAL = new TaxRelation("Equal", " = ", StringOnly.NO);
        public static readonly TaxRelation NOT_EQUAL = new TaxRelation("NotEqual", " <>", StringOnly.NO);
        public static readonly TaxRelation GREATHER_THAN = new TaxRelation("GreaterThan", " > ", StringOnly.NO);
        public static readonly TaxRelation GREATHER_OR_EQUAL = new TaxRelation("GreaterOrEqual", " >=", StringOnly.NO);
        public static readonly TaxRelation LESS_THAN = new TaxRelation("LessThan", " < ", StringOnly.NO);
        public static readonly TaxRelation LESS_OR_EQUAL = new TaxRelation("LessOrEqual", " <=", StringOnly.NO);
        public static readonly TaxRelation DOES_NOT_CONTAIN = new TaxRelation("DoesNotContain", "!%%", StringOnly.YES);
        public static readonly TaxRelation DOES_NOT_START_WITH = new TaxRelation("DoesNotStartWith", "!%=", StringOnly.YES);
        public static readonly TaxRelation DOES_NOT_END_WITH = new TaxRelation("DoesNotEndWith", "!=%", StringOnly.YES);
        public static readonly TaxRelation LENGTH_EQUAL = new TaxRelation("NoOfCharactersEqual", "#==", StringOnly.YES);
        public static readonly TaxRelation LENGTH_NOT_EQUAL = new TaxRelation("NoOfCharactersGreaterThan", "#> ", StringOnly.YES);
        public static readonly TaxRelation LENGTH_GREATHER_THAN = new TaxRelation("NoOfCharactersGreaterThan", "#> ", StringOnly.YES);
        public static readonly TaxRelation LENGTH_GREATHER_OR_EQUAL = new TaxRelation("NoOfCharactersGreaterOrEqual", "#>=", StringOnly.YES);
        public static readonly TaxRelation LENGTH_LESS_THAN = new TaxRelation("NoOfCharactersLessThan", "#< ", StringOnly.YES);
        public static readonly TaxRelation LENGTH_LESS_OR_EQUAL = new TaxRelation("NoOfCharactersLessOrEqual", "#<=", StringOnly.YES);

        public static IEnumerable<TaxRelation> Values
        {
            get
            {
                yield return NO_RELATION;
                yield return CONTAINS;
                yield return STARTS_WITH;
                yield return ENDS_WITH;
                yield return EQUAL;
                yield return NOT_EQUAL;
                yield return GREATHER_THAN;
                yield return GREATHER_OR_EQUAL;
                yield return LESS_THAN;
                yield return LESS_OR_EQUAL;
                yield return DOES_NOT_CONTAIN;
                yield return DOES_NOT_START_WITH;
                yield return DOES_NOT_END_WITH;
                yield return LENGTH_EQUAL;
                yield return LENGTH_NOT_EQUAL;
                yield return LENGTH_GREATHER_THAN;
                yield return LENGTH_GREATHER_OR_EQUAL;
                yield return LENGTH_LESS_THAN;
                yield return LENGTH_LESS_OR_EQUAL;

            }
        }

        public enum StringOnly
        {
            YES,
            NO
        }


        private readonly string description;
        private readonly string symbol;
        private readonly StringOnly stringOnlyValue;


        public string Description { get; private set; }
        public string Symbol { get; private set; }
        public StringOnly StringOnlyValue { get; }



        TaxRelation(string description, string symbol, StringOnly stringOnlyValue)
        {
            (Description) = (description);
            (Symbol) = (symbol);
            (StringOnlyValue) = (stringOnlyValue);
        }

        public override string ToString() => description;
        public static TaxRelation Of(string description)
        {
            if (description == null)
            {
                return NO_RELATION;
            }

            foreach (TaxRelation item in Values)
            {
                if (string.Equals(description, item.Description, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return NO_RELATION;
        }
    }
}

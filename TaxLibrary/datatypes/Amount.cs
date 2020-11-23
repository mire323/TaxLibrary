using System;
using System.Collections.Generic;
using System.Text;
using java.math;

namespace TaxLibrary.datatypes
{
    class Amount : DecimalNumber
    {
        private static long serialVersionUID = 1L;
        private static int NUMBER_OF_AMOUNT_DECIMALS = 2;
        private static readonly BigDecimal ZERO_VALUE = (new Amount(DecimalNumber.ZERO)).Value;

        public Amount(BigDecimal value) : base(NUMBER_OF_AMOUNT_DECIMALS)
        {
            Value = value;
        }

        public Amount(double value) : this(BigDecimal.valueOf(value))
        {
        }

        public void Add(Amount otherValue)
        {
            Value = Value.add(otherValue.Value);
        }

        public void Subtract(Amount otherValue)
        {
            Value = Value.subtract(otherValue.Value); 
        }
    }
}

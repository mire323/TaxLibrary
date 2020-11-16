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
        private static readonly BigDecimal ZERO_VALUE = (new Amount(DecimalNumber.ZERO)).getValue();

        public Amount(BigDecimal value) : base(NUMBER_OF_AMOUNT_DECIMALS)
        {
            setValue(value);
        }

        public Amount(double value) : this(BigDecimal.valueOf(value))
        {
        }

        public void add(Amount otherValue)
        {
            setValue(getValue().add(otherValue.getValue()));
        }

        public void subtract(Amount otherValue)
        {
            setValue(getValue().subtract(otherValue.getValue()));
        }
    }
}

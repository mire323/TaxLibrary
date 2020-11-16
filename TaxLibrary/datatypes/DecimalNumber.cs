using System;
using System.Collections.Generic;
using System.Text;
using java.math;

namespace TaxLibrary.datatypes
{
    class DecimalNumber
    {
        protected static readonly BigDecimal ZERO = java.math.BigDecimal.ZERO;
        protected static readonly RoundingMode DEFAULT_ROUNDING_MODE = RoundingMode.HALF_EVEN;

        private BigDecimal value;
        private int decimals;

        public DecimalNumber(int decimals)
        {
            setPrecision(decimals);
            setValue(ZERO);
        }

        public DecimalNumber(int decimals, BigDecimal value) : this(decimals)
        {
            setValue(value);
        }

        // Nisam siguran sta ovde treba uopste
        //public final BigDecimal protected static BigDecimal ZERO => zERO;

        public BigDecimal getValue()
        {
            return value;
        }

        private void setPrecision(int decimals)
        {
            this.decimals = decimals;
        }

        public int getPrecision()
        {
            return decimals;
        }

        public void setValue(BigDecimal value)
        {
            this.value = value.setScale(decimals, DEFAULT_ROUNDING_MODE);
        }

        public void add(DecimalNumber otherValue)
        {
            this.value = value.add(otherValue.getValue()).setScale(decimals, DEFAULT_ROUNDING_MODE);
        }

        public void subtract(DecimalNumber otherValue)
        {
            this.value = value.subtract(otherValue.getValue()).setScale(decimals, DEFAULT_ROUNDING_MODE);
        }

        public void multiply(Int32 otherValue)
        {
            this.value = value.multiply(new BigDecimal(otherValue)).setScale(decimals, DEFAULT_ROUNDING_MODE);
        }


        public override String ToString()
        {
            return value.toPlainString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using java.math;

namespace TaxLibrary.datatypes
{
    class DecimalNumber
    {
        protected static readonly BigDecimal ZERO = BigDecimal.ZERO;
        protected static readonly RoundingMode DEFAULT_ROUNDING_MODE = RoundingMode.HALF_EVEN;

        private BigDecimal value;
        private int decimals;

        public DecimalNumber(int decimals)
        {
            SetPrecision(decimals);
            Value = ZERO;
        }

        public DecimalNumber(int decimals, BigDecimal value) : this(decimals)
        {
            Value = value;
        }

        // Nisam siguran sta ovde treba uopste
        //public final BigDecimal protected static BigDecimal ZERO => zERO;


        public BigDecimal Value { get { return this.value; } set { this.value = value.setScale(decimals, DEFAULT_ROUNDING_MODE); }  }
        public int Decimal { get { return this.decimals; } set { this.decimals = value; } }

        private void SetPrecision(int decimals)
        {
            this.decimals = decimals;
        }
        

        public void Add(DecimalNumber otherValue)
        {
            this.value = value.add(otherValue.Value).setScale(decimals, DEFAULT_ROUNDING_MODE);
        }

        public void Subtract(DecimalNumber otherValue)
        {
            this.value = value.subtract(otherValue.Value).setScale(decimals, DEFAULT_ROUNDING_MODE);
        }

        public void Multiply(Int32 otherValue)
        {
            this.value = value.multiply(new BigDecimal(otherValue)).setScale(decimals, DEFAULT_ROUNDING_MODE);
        }


        public override String ToString()
        {
            return value.toPlainString();
        }
    }
}

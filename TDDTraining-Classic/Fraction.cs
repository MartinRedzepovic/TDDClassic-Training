using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTraining_Classic
{
    public class Fraction
    {
        public int Nominator { get;  }
        public int Denominator { get; }

        public Fraction(int nominator, int denominator)
        {
            Nominator = nominator;
            Denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            var newDenominator = Math.Max(other.Denominator, Denominator);
            var newNominator = Nominator * (newDenominator / Denominator) +
                               other.Nominator * (newDenominator / other.Denominator);
            return new Fraction(newNominator, newDenominator);
        }

        public override string ToString()
        {
            return $"{Nominator}/{Denominator}";
        }
    }
}

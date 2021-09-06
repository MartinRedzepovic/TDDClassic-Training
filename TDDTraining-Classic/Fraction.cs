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
            var newDenominator = Denominator * other.Denominator;
            var newNominator = Nominator * (newDenominator / Denominator) +
                               other.Nominator * (newDenominator / other.Denominator);
            var gcd = CalculateGreatestCommonDivisor(newNominator, newDenominator);

            return new Fraction(newNominator / gcd, newDenominator / gcd);
        }

        private int CalculateGreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : CalculateGreatestCommonDivisor(b, a % b);
        }

        public override string ToString()
        {
            return Nominator % Denominator == 0 ? $"{Nominator / Denominator}" : $"{Nominator}/{Denominator}";
        }
    }
}

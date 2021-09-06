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
            return new Fraction(Nominator + other.Nominator, Denominator);
        }

        public override string ToString()
        {
            return $"{Nominator}/{Denominator}";
        }
    }
}

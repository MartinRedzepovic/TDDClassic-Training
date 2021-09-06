using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace TDDTraining_Classic.Tests
{
    [TestFixture]
    class FractionTests
    {
        [Test]
        public void Add_TwoFractionsWithSameDenominator()
        {
            // given
            var fraction1 = new Fraction(1, 7);
            var fraction2 = new Fraction(5, 7);

            // when
            var result = fraction1.Add(fraction2);

            // then
            result.ToString().Should().Be("6/7");
        }
    }
}

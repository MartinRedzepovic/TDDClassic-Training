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

        [Test]
        public void Add_TwoFractionsWhereOneDenominatorIsMultipleOfTheOtherOne()
        {
            // given
            var fraction1 = new Fraction(3, 4);
            var fraction2 = new Fraction(3, 8);

            // when
            var result = fraction1.Add(fraction2);

            // then
            result.ToString().Should().Be("9/8");
        }

        [Test]
        public void Add_TwoFractionWhereOneDenominatorIsNotMultipleOfOtherOne()
        {
            // given
            var fraction1 = new Fraction(1, 7);
            var fraction2 = new Fraction(1, 3);

            // when
            var result = fraction1.Add(fraction2);

            // then
            result.ToString().Should().Be("10/21");
        }

        [Test]
        public void Add_ResultIsReduced()
        {
            // given
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(1, 4);

            // when
            var result = fraction1.Add(fraction2);

            // then
            result.ToString().Should().Be("1/2");
        }

        [Test]
        public void Add_ResultIsIntegerIfResultNominatorIsDivisableByDenominator()
        {
            // given
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 2);

            // when
            var result = fraction1.Add(fraction2);

            // then
            result.ToString().Should().Be("1");
        }
    }
}

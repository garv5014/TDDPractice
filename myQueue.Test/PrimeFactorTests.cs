using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TDDProjects.Test;

public class PrimeFactorTests
{
    private PrimeFactors _primeFactors;
    [SetUp]
    public void Setup()
    {
        _primeFactors = new PrimeFactors();
    }
    [Test]
    public void PrimeFactorOfOne()
    {
        _primeFactors.FindFactors(1).Should().BeEmpty();
    }
    [Test]
    public void PrimeFactorOfTwo()
    {
        _primeFactors.FindFactors(2).Should().OnlyContain(f => f == 2 );
    }

    [Test]
    public void PrimeFactorOfThree()
    {
        _primeFactors.FindFactors(3).Should().Contain(3);
    }

    [Test]
    public void PrimeFactorOfFour()
    {
        _primeFactors.FindFactors(4).Should().Contain(new int[] { 2, 2 });
    }
}

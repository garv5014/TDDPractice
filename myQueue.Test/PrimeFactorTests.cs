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
        _primeFactors.FindFactors(2).Should().BeEquivalentTo(new List<int> { 2 });
    }

    [Test]
    public void PrimeFactorOfThree()
    {
        _primeFactors.FindFactors(3).Should().BeEquivalentTo(new List<int> { 3 });
    }

    [Test]
    public void PrimeFactorOfFour()
    {
        _primeFactors.FindFactors(4).Should().BeEquivalentTo(new List<int> { 2, 2 });
    }
    [Test]
    public void PrimeFactorOfFive()
    {
        _primeFactors.FindFactors(5).Should().BeEquivalentTo(new List<int> { 5 });
    }
    [Test]
    public void PrimeFactorOfSix()
    {
        _primeFactors.FindFactors(6).Should().BeEquivalentTo(new List<int> { 2, 3 });
    }
    [Test]
    public void PrimeFactorOfSeven()
    {
        _primeFactors.FindFactors(7).Should().BeEquivalentTo(new List<int> { 7 });
    }
    [Test]
    public void PrimeFactorOfEight()
    {
        _primeFactors.FindFactors(8).Should().BeEquivalentTo(new List<int> { 2, 2, 2 });
    }

    [Test]
    public void PrimeFactorOfNine()
    {
        _primeFactors.FindFactors(9).Should().BeEquivalentTo(new List<int> { 3,3 });
    }

    [Test]
    public void PrimeFactorOfBigNumber()
    {
        _primeFactors.FindFactors(2*2*3*3*5*5*7*7).Should().BeEquivalentTo(new List<int> { 2 , 2 , 3 , 3 , 5 , 5 , 7 , 7 });
    }
}

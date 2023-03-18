using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProjects.Library;

public class PrimeFactors
{
    public List<int> FindFactors(int n)
    {
        var factors = new List<int>();
        if (n % 2 == 0)
        {
            factors.Add(n);
        }
        return factors;
    }
}

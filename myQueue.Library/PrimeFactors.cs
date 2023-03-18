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
        if (n > 1)
        {
            while (n % 2 == 0)
            {
                factors.Add(2);
                n /= 2;
            }
        }
        if (n > 1)
            factors.Add(n);
        return factors;
    }
}

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
        int divisor = 2;
        while (n > 1)
        {
            while (n % divisor == 0) //while is a general form of if, and if is the degenerate form of while.
            {
                factors.Add(divisor);
                n /= divisor;
            }
            divisor++;
        }
        if (n > 1)
            factors.Add(n);
        return factors;
    }
}

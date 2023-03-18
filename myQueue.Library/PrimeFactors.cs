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
        for (int divisor = 2; n > 1; divisor++)
            for (; n % divisor == 0; n /= divisor)
                factors.Add(divisor);
        return factors;
    }
}

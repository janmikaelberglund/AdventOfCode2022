using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal static class Day4
    {
        public static int FindSuperfluous(string[] input)
        {
            return input
                    .Select(line => line.Split(new[] { ',', '-' }))
                    .Count(x => int.Parse(x[0]) >= int.Parse(x[2]) && int.Parse(x[1]) <= int.Parse(x[3]) 
                            || int.Parse(x[2]) >= int.Parse(x[0]) && int.Parse(x[3]) <= int.Parse(x[1]));
        }

        internal static int FindOverlaps(string[] input)
        {
            return input
                .Select(line => line.Split(new[] { ',', '-' }))
                .Count(x => int.Parse(x[0]) >= int.Parse(x[2]) && int.Parse(x[0]) <= int.Parse(x[3])
                        || int.Parse(x[1]) >= int.Parse(x[2]) && int.Parse(x[1]) <= int.Parse(x[3])
                        || int.Parse(x[2]) >= int.Parse(x[0]) && int.Parse(x[3]) <= int.Parse(x[1]));
        }
    }
}

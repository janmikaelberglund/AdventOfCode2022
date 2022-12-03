using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Day3
    {
        public string[] input { get; set; }
        public Day3(string[] input)
        {
            this.input = input;
        }

        internal int SumOfPriorities()
        {
            return input.Sum(x => GetPriority(x));
        }

        private int GetPriority(string backpack)
        {
            var left = backpack.Substring(0, backpack.Length / 2);
            var right = backpack.Substring(backpack.Length / 2);

            char? duplicate = null;
            foreach (var letter in left)
            {
                if (right.Contains(letter))
                {
                    duplicate = letter;
                    break;
                }
            }

            return duplicate < 'a' ? (int)duplicate - 38 : (int)duplicate! - 96;
        }
    }
}

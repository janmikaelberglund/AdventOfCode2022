using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Day5
    {
        public List<Stack<char>> CrateStack = new();
        public List<List<int>> Moves = new();

        internal void SetupCratesAndMoves(string[] input)
        {
            var initial = input
                .TakeWhile(x => !x.StartsWith(" 1"))
                .Select(x => x.Replace("] ", ""))
                .Select(x => x.Replace("]", ""))
                .Select(x => x.Replace("[", ""))
                .Select(x => x.Replace("    ", "   "))
                .Select(x => x.Replace("   ", " "))
                .ToList();


            var len = initial.Select(x => x.Length).OrderByDescending(x => x).First();
            for (int i = 0; i < int.Parse(input[initial.Count].Trim().Last().ToString()); i++)
            {
                CrateStack.Add(new Stack<char>());
                for (int j = initial.Count - 1; j >= 0; j--)
                {
                    var crate = initial[j][i];
                    if (crate != 32)
                    {
                        CrateStack[i].Push(crate);
                    }
                }
            }

            Moves = input.Skip(initial.Count + 2).Select(x => x.Split(new[] { "move ", " from ", " to " }, StringSplitOptions.RemoveEmptyEntries))
                .Select(x => x.Select(y => int.Parse(y)).ToList()).ToList();
        }

        internal void UseCrateMover9001(List<int> move)
        {
            var cratesToMove = "";
            for (int i = 0; i < move[0]; i++)
            {
                cratesToMove += CrateStack[move[1] - 1].Pop();
            }
            cratesToMove = string.Join("", cratesToMove.Select(c => c).Reverse());
            for (int i = 0; i < cratesToMove.Length; i++)
            {
                CrateStack[move[2] - 1].Push(cratesToMove[i]);
            }
        }

        internal void UseCrateMover9000(List<int> move)
        {
            for (int i = 0; i < move[0]; i++)
            {
                CrateStack[move[2] - 1].Push(CrateStack[move[1] - 1].Pop());
            }
        }
    }
}

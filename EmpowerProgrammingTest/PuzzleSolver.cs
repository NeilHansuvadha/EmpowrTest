using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowrProgrammingTest
{
    public static class PuzzleSolver
    {
        public static string[] DICTIONARY = { "OX", "CAT", "TOY", "AT", "DOG", "CATAPULT", "T" };

        static bool IsWord(string testWord)
        {
            if (DICTIONARY.Contains(testWord))
                return true;
            return false;
        }

        public static int FindWords(char[,] puzzle)
        {
            string str = "";
            int myCount = 0;

            for (int i = 0; i < puzzle.GetLength(0); i++)
            {
                for (int j = 0; j < puzzle.GetLength(1); j++)
                {
                    str += puzzle[i, j].ToString();

                    if (IsWord(str) == true) { myCount++; };
                }
            }

            return myCount;
        }

        private static void Main()
        {
            char[,] Puzzle = new char[3,3];

            Puzzle[0,0] = 'c';
            Puzzle[0,1] = 'a';
            Puzzle[0,2] = 't';

            Puzzle[1,0] = 'x';
            Puzzle[1,1] = 'z';
            Puzzle[1,2] = 't';

            Puzzle[2,0] = 'y';
            Puzzle[2,1] = 'o';
            Puzzle[2,2] = 't';

            System.Console.WriteLine(FindWords(Puzzle));            
        }
    }

}

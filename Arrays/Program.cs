using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = 5;
            int[][] a = new int[dimension][];

            for (int i = 0; i < dimension; i++)
            {
                a[i] = new int[i + 1];

                for (int j = 0; j < i + 1; j++)
                {
                    int prevRow = i - 1;
                    int prevColLeft = j - 1;
                    int prevColRight = j;
                    int valueLeft = 0, valueRight = 0;

                    if (prevRow >= 0)
                    {
                        if (prevColLeft >= 0)
                        {
                            valueLeft = a[prevRow][prevColLeft];
                        }

                        if (prevColRight < a[prevRow].Length)
                        {
                            valueRight = a[prevRow][prevColRight];
                        }
                    }
                    else
                    {
                        valueLeft = 1;
                    }

                    a[i][j] = valueLeft + valueRight;
                }
            }

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

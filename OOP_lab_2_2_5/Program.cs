using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace OOP_lab_2_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[][] A = new int[int.Parse(elements[1])][];

            var random = new Random();

            for (int i = 0; i < A.Length; ++i)
            {
                A[i] = new int[int.Parse(elements[0])];

                for (int j = 0; j < A[i].Length; ++j)
                {
                    A[i][j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    Console.Write("{0, -6}", A[i][j]);
                }

                Console.WriteLine("\n");
            }

            int max = A[0][0];

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    if (A[i][j] >= max)
                    {
                        max = A[i][j];
                    }
                }
            }

            int k = 0;

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    if (A[i][j] == max)
                    {
                        ++k;
                        A[i][j] = -999999999;
                    }

                    if (k == 2)
                    {
                        goto End;
                    }
                }
            }

            max = A[0][0];

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    if (A[i][j] >= max)
                    {
                        max = A[i][j];
                    }
                }
            }

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    if (A[i][j] == max)
                    {
                        ++k;
                        A[i][j] = -999999999;
                    }

                    if (k == 2)
                    {
                        goto End;
                    }
                }
            }

            End:
            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    if (A[i][j] == -999999999)
                    {
                        A[i][j] = 0;
                    }
                }
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    Console.Write("{0, -6}", A[i][j]);
                }

                Console.WriteLine("\n");
            }
        }
    }
}

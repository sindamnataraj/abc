using System;
using System.Collections.Generic;
using System.Text;

namespace Kasi
{
    public static class Tools
    {
        public static void swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public static void printArray(int[] A)
        {
            foreach (int a in A)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();
        }
    }
}

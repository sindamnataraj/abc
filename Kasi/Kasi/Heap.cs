using System;
using System.Collections.Generic;
using System.Text;

namespace Kasi
{
    public class Heap
    {
        private int[] A;
        private int heapLen;

        public Heap(int[] A1)
        {
            this.A = new int[A1.Length];
            Array.Copy(A1, A, A1.Length);
            buildMaxHeap(A, ref heapLen);
        }
        public void heapsort()
        {
            while (this.heapLen > 0)
            {
                Tools.swap(A, 0, this.heapLen);
                
                this.heapLen--;
                maxHeapify(A, 0, this.heapLen);
            }

            showheap();
        }

        public void showheap()
        {
            Tools.printArray(this.A);    
        }

        private static void buildMaxHeap(int[] A,ref int heapLen)
        {
            heapLen = A.Length - 1;
            for (int i = (A.Length / 2) - 1; i >= 0; i--)
            {
                maxHeapify(A, i, heapLen);
            }
        }
        private static void maxHeapify(int[] A, int i,int heapLen)
        {
            int left = Left(i);
            int right = Right(i);
            int max = i;
            if (left <= heapLen && A[left] > A[max]) max = left;
            if (right <= heapLen && A[right] > A[max]) max = right;
            if (max != i)
            {
                Tools.swap(A, i, max);

                maxHeapify(A, max, heapLen);
            }
        }

        public static int Left(int i)
        {
            return (2 * i) + 1;
        }

        public static int Right(int i)
        {
            return (2 * i) + 2;
        }
    }
}

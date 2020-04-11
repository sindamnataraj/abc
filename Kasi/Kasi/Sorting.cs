using System;
using System.Collections.Generic;
using System.Text;

namespace Kasi
{
    public static class Sorting
    {
        public static void selectinSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int min = i;
                for(int j=i+1;j<A.Length;j++)
                {
                    if (A[j] < A[min]) min = j;
                }

                if (i != min) Tools.swap(A, i, min);
            }

        }

        public static void insertionSort(int[] A)
        {

            for (int i = 1; i < A.Length; i++)
            {
                int k = A[i];
                int j = i - 1;
                while (j > -1 && A[j] > k)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = k;
            }
        }

        public static void bubbleSort(int[] A)
        {
            for (int i = A.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (A[j] < A[j - 1]) Tools.swap(A, j, j - 1);
                }
            }
        }


        public static void quickSort(int[] A,int p, int q)
        {
            if (p < q)
            {
                int mid = partition(A, p, q);
                quickSort(A, p, mid - 1);
                quickSort(A, mid + 1, q);
            }

        }

        public static int partition(int[] A, int p, int q)
        {
            int i = p;
            int j = i - 1;
            int k = A[q];

            while (i < q)
            {
                if (A[i] < k)
                {
                    Tools.swap(A, j + 1, i);
                    j++;
                }
                i++;
            }

            A[q] = A[j + 1];
            A[j + 1] = k;
            return j + 1;
        }

        public static void mergeSort(int[] A, int p, int q)
        {
            if (p < q)
            {
                int mid = p + (q - p) / 2;
                mergeSort(A, p, mid);
                mergeSort(A, mid + 1, q);
                merge(A, p, mid, q);
            }
        }

        public static void merge(int[] A, int p, int mid, int q)
        {
            int l1 = mid - p + 1;
            int l2 = q - mid;

            int[] left = new int[l1];
            int[] right = new int[l2];

            for (int i1 = 0; i1 < l1; i1++)
            {
                left[i1] = A[p + i1];
            }

            for (int j1 = 0; j1 < l2; j1++)
            {
                right[j1] = A[mid + 1 + j1];
            }

            int i = 0;
            int j = 0;
            int k = p;
            while( i<l1 && j<l2)
            {
                if (left[i] <= right[j])
                {
                    A[k] = left[i];
                    i++;
                }
                else
                {
                    A[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < l1)
            {
                
                    A[k] = left[i];
                    i++;
                
                k++;
            }

            while ( j < l2)
            {
            
                    A[k] = right[j];
                    j++;
            
                k++;
            }


        }

        public static void countingSort(int[] A)
        {
            int k = 10;
            int[] c = new int[k];
            foreach(int a in A)
            {
                c[a]++;
            }

            for (int i = 1; i < c.Length; i++)
            {
                c[i] = c[i] + c[i - 1];
            }

            int[] B = new int[A.Length];
            Array.Copy(A, B, A.Length);

            for (int i = 0; i < B.Length; i++)
            {
                A[c[B[i]] -1] = B[i];
                c[B[i]]--;
            }


        }

    }
}

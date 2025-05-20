using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeOrdenado
{
    internal class Sort
    {
        public static void Print(int[] array)
        {
            foreach (var node in array)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();
        }

        public static int[] DescendingBubble(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int aux = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = aux;
                    }
                }
            }

            return array;
        }

        public static int[] AscendingBubble(ref int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }

            return array;
        }

        public static int[] FlaggedBubble(ref int[] array)
        {
            int i = 0;
            bool flag = false;
            while (i < array.Length && !flag)
            {
                flag = true;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                        flag = false;
                    }
                }
                i++;
            }

            return array;
        }

        public static int[] Shaker(ref int[] array)
        {
            int left = 1;
            int right = array.Length - 1;
            int pos = array.Length - 1;

            while (right >= left)
            {
                for (int i = right; i >= left; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        int aux = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = aux;
                        pos = i;
                    }
                }
                left = pos + 1;

                for (int i = left; i <= right; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        int aux = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = aux;
                        pos = i;
                    }
                }
                right = pos - 1;
            }

            return array;
        }

        public static int[] Insertion(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int aux = array[i];
                int pos = i - 1;

                while (pos >= 0 && aux < array[pos])
                {
                    array[pos + 1] = array[pos];
                    pos--;
                }
                array[pos + 1] = aux;
            }

            return array;
        }

        public static int[] BinaryInsertion(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int aux = array[i];
                int left = 0;
                int right = i - 1;

                while (left <= right)
                {
                    int middle = (left + right) / 2;

                    if (aux <= array[middle])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                int j = i - 1;

                while (j >= left)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[left] = aux;
            }

            return array;
        }

        public static int[] Selection(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];
                int pos = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        pos = j;
                    }
                }
                array[pos] = array[i];
                array[i] = min;
            }

            return array;
        }

        public static int[] Shell(ref int[] array)
        {
            int interval = array.Length;
            while (interval > 1)
            {
                interval = interval / 2;
                bool flag = true;

                while (flag == true)
                {
                    flag = false;
                    int pos = 0;

                    while ((pos + interval) < array.Length)
                    {
                        if (array[pos] > array[pos + interval])
                        {
                            int aux = array[pos];
                            array[pos] = array[pos + interval];
                            array[pos + interval] = aux;
                            flag = true;
                        }
                        pos++;
                    }
                }
            }

            return array;
        }

        public static int[] Quick(ref int[] array)
        {
            int top = 0;
            int[] left = new int[array.Length];
            int[] right = new int[array.Length];
            left[top] = 0;
            right[top] = array.Length - 1;

            while (top >= 0)
            {
                int start = left[top];
                int end = right[top];
                top--;
                int pos = Partition(ref array, start, end);

                if (start < pos - 1)
                {
                    top++;
                    left[top] = start;
                    right[top] = pos - 1;
                }

                if (end > pos + 1)
                {
                    top++;
                    left[top] = pos + 1;
                    right[top] = end;
                }
            }

            return array;
        }

        private static int Partition(ref int[] array, int start, int end)
        {
            int left = start;
            int right = end;
            int pos = start;
            bool flag = true;

            while (flag)
            {
                while (array[pos] <= array[right] && pos != right)
                {
                    right--;
                }

                if (pos == right)
                {
                    flag = false;
                }
                else
                {
                    int aux = array[pos];
                    array[pos] = array[right];
                    array[right] = aux;
                    pos = right;
                }

                while (array[pos] >= array[left] && pos != left)
                {
                    left++;
                }

                if (pos == left)
                {
                    flag = false;
                }
                else
                {
                    int aux = array[pos];
                    array[pos] = array[left];
                    array[left] = aux;
                    pos = left;
                }
            }

            return pos;
        }

        public static int[] Heap(ref int[] array)
        {
            InsertHeap(ref array);
            DeleteHeap(ref array);
            return array;
        }

        private static int[] InsertHeap(ref int[] array)
        {
            int n = array.Length;

            // Construir el heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(ref array, n, i);
            }

            return array;
        }

        private static int[] DeleteHeap(ref int[] array)
        {
            int n = array.Length;

            for (int i = n - 1; i > 0; i--)
            {
                // Intercambiar el primero (máximo) con el último del heap
                int aux = array[i];
                array[i] = array[0];
                array[0] = aux;

                // Reajustar el heap reducido
                Heapify(ref array, i, 0);
            }

            return array;
        }

        private static void Heapify(ref int[] array, int n, int pos)
        {
            int left = 2 * pos + 1;
            int right = 2 * pos + 2;
            int ap = pos;

            if (left < n && array[left] > array[ap])
            {
                ap = left;
            }

            if (right < n && array[right] > array[ap])
            {
                ap = right;
            }

            if (ap != pos)
            {
                int aux = array[pos];
                array[pos] = array[ap];
                array[ap] = aux;

                Heapify(ref array, n, ap);
            }
        }
    }
}

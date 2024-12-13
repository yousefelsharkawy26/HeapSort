﻿namespace Algorithm_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1000];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }

            Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\n");
            }
        }
        static int lastIndex;

        static void Sort(int[] arr)
        {
            lastIndex = arr.Length - 1;

            for (int i = lastIndex / 2; i >= 0; i--)
                Heapify(arr, i);

            for (int i = lastIndex - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                lastIndex--;
                Heapify(arr, 0);
            }
            
        }
        static void Heapify(int[] arr, int PIndex)
        {
            int LChild = PIndex * 2;
            int RChild = PIndex * 2 + 1;
            int NewIndex = PIndex;

            if (LChild < lastIndex && arr[LChild] > arr[PIndex])
                NewIndex = LChild;
            if (RChild < lastIndex && arr[RChild] > arr[NewIndex])
                NewIndex = RChild;

            if (NewIndex != PIndex)
            {
                Swap(arr, PIndex, NewIndex);
                Heapify(arr, NewIndex);
            }
        }

        static void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}

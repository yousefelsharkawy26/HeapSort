namespace HeapSort
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

            clsHeapSort.HeapSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\n");
            }
        }
        
    }
}

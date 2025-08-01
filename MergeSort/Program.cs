namespace MergeSort
{
    internal class Program
    {
        public void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }

        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            var arr1 = new int[middle+1];
            var arr2 = new int[right-middle];
            for (int i = 0; i <= middle; i++) {
               arr1[i] = array[i];        
            }
            for (int j = 0; j < right-middle; j++) {
                arr2[j] = array[middle+1+j];
            }       
            int l = 0;
            int r = 0;
            int t = 0;
            while (l != arr1.Length && r != arr2.Length)
            {
                if (arr1[l] > arr2[r])
                {
                    array[t]=arr2[r];
                    r++;
                    t++;
                }
                else
                {
                    array[t] = arr1[l];
                    l++;
                    t++;
                }
            }
            while (l < arr1.Length)
            {                    
                    array[t] = arr1[l];
                    l++;
                    t++;            
            }
            while (r < arr2.Length)
            {
                array[t] = arr2[r];
                r++;
                t++;
            }
        }

        static void Main(string[] args)
        {
            var program = new Program();
    
            // Test case 1: Basic unsorted array
            int[] testArray1 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array: " + string.Join(", ", testArray1));
            program.MergeSort(testArray1, 0, testArray1.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", testArray1));
    
            // Test case 2: Already sorted array
            int[] testArray2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nAlready sorted: " + string.Join(", ", testArray2));
            program.MergeSort(testArray2, 0, testArray2.Length - 1);
            Console.WriteLine("After sorting: " + string.Join(", ", testArray2));
    
            // Test case 3: Reverse sorted array
            int[] testArray3 = { 5, 4, 3, 2, 1 };
            Console.WriteLine("\nReverse sorted: " + string.Join(", ", testArray3));
            program.MergeSort(testArray3, 0, testArray3.Length - 1);
            Console.WriteLine("After sorting: " + string.Join(", ", testArray3));
    
            // Test case 4: Single element
            int[] testArray4 = { 42 };
            Console.WriteLine("\nSingle element: " + string.Join(", ", testArray4));
            program.MergeSort(testArray4, 0, testArray4.Length - 1);
            Console.WriteLine("After sorting: " + string.Join(", ", testArray4));
        }
    }
}

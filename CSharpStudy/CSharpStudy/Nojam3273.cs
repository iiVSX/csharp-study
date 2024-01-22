namespace CSharpStudy
{
    class Nojam3273
    {
        public static void Solution(string[] args)
        {
            int n, x;
            n = Int32.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(s[i]);
            }

            x = Int32.Parse(Console.ReadLine());
            
            Array.Sort(arr);
            int start = 0, end = n-1;
            int result = 0;
            while (start < end)
            {
                int sum = arr[start] + arr[end];
                if (sum >= x)
                {
                    end--;
                }

                if (sum <= x)
                {
                    start++;
                }

                if (sum == x)
                {
                    result++;
                }
            }
            
            Console.WriteLine(result);
        }
    }    
}
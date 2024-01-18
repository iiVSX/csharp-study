namespace CSharpStudy
{
    class Nojam2559
    {
        public static void Solution(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = Int32.Parse(input[0]);
            int k = Int32.Parse(input[1]);

            string[] arr = Console.ReadLine().Split();
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += Int32.Parse(arr[i]);
            }

            int result = sum;
            for (int i = k; i < n; i++)
            {
                sum = Int32.Parse(arr[i]) + sum - Int32.Parse(arr[i - k]);
                result = Math.Max(result, sum);
            }
            
            Console.WriteLine(result);
        }
    }    
}
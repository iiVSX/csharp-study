namespace CSharpStudy
{
    class Nojam10844
    {
        const int Mod = (int)1e9;
        public static void Solution(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[,] dp = new int[n, 10];
            for (int i = 0; i < 10; i++)
            {
                dp[0, i] = i == 0 ? 0 : 1;
            }
            
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j > 0 && !(j == 1 && i == 1))
                    {
                        dp[i, j] = (dp[i, j] + dp[i - 1, j - 1]) % Mod;
                    }

                    if (j < 9)
                    {
                        dp[i, j] = (dp[i, j] + dp[i - 1, j + 1]) % Mod;
                    }
                }
            }

            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                result = (dp[n-1, i] + result) % Mod;
            }

            Console.WriteLine(result);
        }
    }    
}
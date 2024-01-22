namespace Test {
    class Nojam16496 {
        public class Comparer : IComparer<int> {
            public int Compare(int n1, int n2)
            {
                string s1 = n1.ToString() + n2.ToString();
                string s2 = n2.ToString() + n1.ToString();
                return s2.CompareTo(s1);
            }
        }

        static void Main(string[] args) {
            int n = Int32.Parse(Console.ReadLine());
            PriorityQueue<int, int> pQueue = new PriorityQueue<int, int>(new Comparer());
            IEnumerator<int> e = Console.ReadLine().Split().Select(d => Int32.Parse(d)).GetEnumerator();
            while (e.MoveNext()) {
                pQueue.Enqueue(e.Current, e.Current);
            }

            string result = "";
            while (pQueue.Count != 0) {
                result += pQueue.Dequeue().ToString();       
            }

            if (result.StartsWith("0")) {
                result = "0";
            }

            Console.WriteLine(result);
        }
    }
}
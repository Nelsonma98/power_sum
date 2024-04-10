namespace power_sum;

class Program
{
    static int res;
    // static List<int> sumandos;
    static void Main(string[] args)
    {
        // PowerSum(500, 2);
        Console.WriteLine(PowerSum(500, 2));
    }

    static int PowerSum(int X, int N)
    {
        // sumandos = new List<int>();
        res = 0;
        PowerSumGenerator(1, 0, X, N);
        return res;
    }

    static void PowerSumGenerator(int i, int sum, int X, int N)
    {
        if (sum == X)
        {
            res++;
            // foreach (int element in sumandos)
            // {
            //     Console.Write(element + " ");
            // }
            // Console.WriteLine("");
        }
        if (i <= Math.Pow(X, 1.0 / N) && sum < X)
        {
            PowerSumGenerator(i + 1, sum, X, N);
            // sumandos.Add(i);
            PowerSumGenerator(i + 1, sum + (int)(Math.Pow(i, N)), X, N);
            // sumandos.RemoveAt(sumandos.Count - 1);
        }
    }
}

namespace Matrix2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ')
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Main diagonal: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
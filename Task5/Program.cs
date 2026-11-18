using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int nomer = 8;
        int n = 5;
        int[,] matrix = new int[n, n];
        Random rnd = new Random(nomer);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = rnd.Next(-10, 11);

        PrintMatrix(matrix);

        long product;
        int count = CountEvenPositiveAboveDiagonal(matrix, out product);

        if (count == 0)
        {
            Console.WriteLine("Бас диагональдан жоғары жұп оң элементтер жоқ");
        }
        else
        {
            Console.WriteLine($"Бас диагональдан жоғары жұп оң элементтер саны = {count}");
            Console.WriteLine($"Бас диагональдан жоғары жұп оң элементтер көбейтіндісі = {product}");
        }
    }

    static void PrintMatrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write($"{m[i, j],4}");
            Console.WriteLine();
        }
    }

    static int CountEvenPositiveAboveDiagonal(int[,] m, out long product)
    {
        int count = 0;
        product = 1;
        for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1); j++)
                if (j > i && m[i, j] > 0 && m[i, j] % 2 == 0)
                {
                    product *= m[i, j];
                    count++;
                }
        return count;
    }
}
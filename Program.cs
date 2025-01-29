namespace matrixExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows the matrix will have: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns the matrix will have: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int r = 0; r < m; r++) { 
                string[] values = Console.ReadLine().Split(' ');
                for (int c = 0; c < n; c++)
                {
                    mat[r,c] = int.Parse(values[c]);
                }
            }

            Console.Write("Enter the number you want information about: ");
            int num = int.Parse(Console.ReadLine());

            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (num == mat[r, c])
                    {
                        Console.WriteLine("Position: " + r + "," + c );
                        if (c > 0)
                        {
                            Console.WriteLine("Left: " + mat[r, c - 1]);
                        }
                        if (c < n - 1)
                        { 
                            Console.WriteLine("Right: " + mat[r, c + 1]); 
                        }
                        if (r < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[r + 1, c]);
                        }
                        if (r > 0)
                        {
                            Console.WriteLine("Up: " + mat[r - 1, c]);
                        }
                    }
                }
            }
        }
    }
}

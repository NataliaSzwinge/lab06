using System;
namespace cw1
{
    class Program
    {
        static void Main()
        {
            const int Size = 10;
            int[,] array = new int[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                if (i % 2 == 0) // wiersze parzyste (licząc od zera)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        array[i, j] = i * Size + j + 1; // wypełnianie rosnąco
                    }
                }
                else // wiersze nieparzyste
                {
                    for (int j = 0; j < Size; j++)
                    {
                        array[i, j] = (i + 1) * Size - j; // wypełnianie malejąco
                    }
                }
            }

            // Wyświetlanie tabeli
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(array[i, j] + "\t"); // wyświetlanie wartości elementu
                }
                Console.WriteLine(); // przechodzenie do nowej linii po zakończeniu wiersza
            }

        }
    }
}

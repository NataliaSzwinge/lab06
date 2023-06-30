using System;
namespace cw3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //przerobione kody z zad1 i zad 2
            //zad1

            //Console.WriteLine("Podaj rozmiar tabeli");
            //int Size = Convert.ToInt32(Console.ReadLine());

            //int[,] array = new int[Size, Size];
            //for (int i = 0; i < Size; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        for (int j = 0; j < Size; j++)
            //        {
            //            array[i, j] = i * Size + j + 1;
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < Size; j++)
            //        {
            //            array[i, j] = (i + 1) * Size - j;
            //        }
            //    }
            //}

            //for (int i = 0; i < Size; i++)
            //{
            //    for (int j = 0; j < Size; j++)
            //    {
            //        Console.Write(array[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //zad2


            Console.WriteLine("Podaj rozmiar tabeli");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[Size, Size];

            int currentCol = 0;
            int currentRow = 0;
            int direction = 0; // 0 - prawo; 1 - dół; 2 - lewo; 3 - góra

            for (int currentNumber = 1; currentNumber <= Size * Size; currentNumber++)
            {
                array[currentRow, currentCol] = currentNumber;
                switch (direction)
                {
                    case 0:
                        if (currentCol + 1 >= Size || array[currentRow, currentCol + 1] != 0)
                        {
                            direction = 1;
                            currentRow++;
                        }
                        else
                        {
                            currentCol++;
                        }
                        break;
                    case 1:
                        if (currentRow + 1 >= Size || array[currentRow + 1, currentCol] != 0)
                        {
                            direction = 2;
                            currentCol--;
                        }
                        else
                        {
                            currentRow++;
                        }
                        break;
                    case 2:
                        if (currentCol - 1 < 0 || array[currentRow, currentCol - 1] != 0)
                        {
                            direction = 3;
                            currentRow--;
                        }
                        else
                        {
                            currentCol--;
                        }
                        break;
                    case 3:
                        if (array[currentRow - 1, currentCol] != 0)
                        {
                            direction = 0;
                            currentCol++;
                        }
                        else
                        {
                            currentRow--;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Tablica{0}x{0}:", Size);
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write("{0,3} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
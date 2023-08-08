namespace sem8_hw;
using vgnamespace;
class Program
{
    static void Main(string[] args)
    {
        //Задача 54: Задайте двумерный массив. 
        //Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        void Task54()
        {
            IO.CC();
            int[] Size = new int[2];
            Size = IO.MultiInputInt("Ведите размерность массива через пробел:");
            int SizeI = 6;
            int SizeJ = 5;
            int[,] Arr = new int[SizeI, SizeJ];
            IO.GenRndArrVal(Arr, 0, 100);
            IO.PrintArr(Arr, "До сортировки:", "\t");

            for (int i = 0; i < SizeI; i++)
                for (int s = 0; s < SizeJ; s++) // сортировка элементов строки
                    for (int j = 1; j < SizeJ - s; j++)
                        if (Arr[i, j - 1] < Arr[i, j])
                            (Arr[i, j - 1], Arr[i, j]) = (Arr[i, j], Arr[i, j - 1]);
            IO.PrintArr(Arr, "После сортировки:", "\t");
        }

        //Задача 56: Задайте прямоугольный двумерный массив. 
        //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        void Task56()
        {
            IO.CC();
            int Size;
            Size = IO.MultiInputInt("Ведите размерность массива:")[0];
            int[,] Arr = new int[Size, Size];
            IO.GenRndArrVal(Arr, -9, 10);
            IO.PrintArr(Arr, "Сгенерирован массив:", "\t");
            int Min = 0;
            int IndexI = 0;
            for (int j = 0; j < Size; j++)
                Min += Arr[0, j];
            for (int i = 1, Sum = 0; i < Size; i++, Sum = 0)
            {
                for (int j = 0; j < Size; j++)
                    Sum += Arr[i, j];
                if (Sum < Min)
                {
                    Min = Sum;
                    IndexI = i;
                }

            }
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Строка с наименьшей суммой {Min} является {IndexI}");
        }


        //Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
        void Task58()
        {
            int SizeI = 4;
            int SizeJ = 4;
            int JStart = 0;
            int JEnd = SizeJ - 1;
            int IStart = 0;
            int IEnd = SizeI - 1;
            int[,] Arr = new int[SizeI, SizeJ];
            int c = 1;
            Console.Clear();
            while (JStart <= JEnd && IStart <= IEnd)
            {
                for (int j = JStart; j <= JEnd; j++)
                    Arr[IStart, j] = c++;
                IStart++;
                for (int i = IStart; i <= IEnd; i++)
                    Arr[i, JEnd] = c++;
                JEnd--;
                for (int j = JEnd; j >= JStart; j--)
                    Arr[IEnd, j] = c++;
                IEnd--;
                for (int i = IEnd; i >= IStart; i--)
                    Arr[i, JStart] = c++;
                JStart++;
            }
            IO.PrintArr(Arr, "Заполненный массив", "\t");
        }
        // Проверка
        //Task54();
        //Task56();
        //Task58();
    }
}

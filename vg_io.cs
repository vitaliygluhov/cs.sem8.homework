//v1.08.05.3
namespace vgnamespace
{
    public static class IO
    {
        public static int Input(string msg)
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int[] MultiInputInt(string msg)
        {
            Console.Write(msg + ">");
            string InputText = Console.ReadLine(); // ввод пользовательских данных
            string[] InputWords = InputText.Split(" "); // парсинг введенного текста. раскладываем строку на слова
            int[] arr = new int[InputWords.Length];
            for (int i = 0; i < InputWords.Length; i++)
                int.TryParse(InputWords[i], out arr[i]);
            return arr;
        }
        public static double[] MultiInputDouble(string msg)
        {
            Console.Write(msg + ">");
            string InputText = Console.ReadLine(); // ввод пользовательских данных
            string[] InputWords = InputText.Split(" "); // парсинг введенного текста. раскладываем строку на слова
            double[] arr = new double[InputWords.Length];
            for (int i = 0; i < InputWords.Length; i++)
                double.TryParse(InputWords[i], out arr[i]);
            return arr;
        }

        public static void GenRndArrVal(int[] Arr, int MinValue = 0, int MaxValue = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < Arr.Length; i++)
                Arr[i] = rnd.Next(MinValue, MaxValue);
        }
        public static void GenRndArrVal(double[] Arr, int MinValue = 0, int MaxValue = 1)
        {
            Random rnd = new Random();
            for (int i = 0; i < Arr.Length; i++)
                Arr[i] = Math.Round(MinValue + ((MaxValue - MinValue) * rnd.NextDouble()), 2);
        }
        public static void GenRndArrVal(int[,] Arr, int MinValue = 0, int MaxValue = 100)
        {
            Random rnd = new Random();
            for (int Rows = 0; Rows < Arr.GetLength(0); Rows++)
                for (int Columns = 0; Columns < Arr.GetLength(1); Columns++)
                    Arr[Rows, Columns] = rnd.Next(MinValue, MaxValue);
        }
        public static void GenRndArrVal(double[,] Arr, int MinValue = 0, int MaxValue = 1, int Round = 2)
        {
            Random rnd = new Random();
            for (int Rows = 0; Rows < Arr.GetLength(0); Rows++)
                for (int Columns = 0; Columns < Arr.GetLength(1); Columns++)
                    Arr[Rows, Columns] = Math.Round(MinValue + ((MaxValue - MinValue) * rnd.NextDouble()), Round);
        }
        public static void PrintArr(int[] Arr, string Msg = "", string Div = " ")
        {
            Console.WriteLine($"{Msg}{string.Join(Div, Arr)}");
        }
        public static void PrintArr(int[,] Arr, string Msg = "", string Div = " ")
        {
            Console.WriteLine($"{Msg}");
            for (int Rows = 0; Rows < Arr.GetLength(0); Rows++)
            {
                for (int Columns = 0; Columns < Arr.GetLength(1); Columns++)
                    Console.Write($"{Arr[Rows, Columns]}{Div}");
                Console.WriteLine();
            }

        }
        public static void PrintArr(double[] Arr, string Msg = "", string Div = " ")
        {
            Console.WriteLine($"{Msg}{string.Join(Div, Arr)}");
        }
        public static void PrintArr(double[,] Arr, string Msg = "", string Div = " ")
        {
            Console.WriteLine($"{Msg}");
            for (int Rows = 0; Rows < Arr.GetLength(0); Rows++)
            {
                for (int Columns = 0; Columns < Arr.GetLength(1); Columns++)
                    Console.Write($"{Arr[Rows, Columns]}{Div}");
                Console.WriteLine();
            }
        }
        public static int[] NumToArray(int Input)
        {
            int Count = 0;
            for (int Temp = Input; Temp > 0; Count++)
                Temp = Temp / 10;
            int[] Arr = new int[Count];

            for (int Index = 10, ArrCount = 0; Index <= Math.Pow(10, Count); Index *= 10, ArrCount++)
                Arr[ArrCount] = Input % (Index) / (Index / 10);
            return Arr;
        }

        public static void CC()
        {
            Console.Clear();
        }

    }
}
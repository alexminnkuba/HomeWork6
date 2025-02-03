internal class Program
{
    private static ManualResetEvent generationCompleted = new ManualResetEvent(false);
    private static object fileLock = new object();
    private static void Main(string[] args)
    {
        Thread generationThread = new Thread(GenerateNumbers);
        generationThread.Start();

        Thread sumThread = new Thread(CalcSum);
        sumThread.Start();

        Thread productOfNumbersThread = new Thread(CalcProductsOfNumbers);
        productOfNumbersThread.Start();

        generationThread.Join();
        sumThread.Join();
        productOfNumbersThread.Join();

        Console.WriteLine("Все операции завершены.");
    }
    static void GenerateNumbers()
    {
        try
        {
            Random random = new Random();
            lock (fileLock)
            {
                using (StreamWriter writer = new StreamWriter("numbers.txt"))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        int num1 = random.Next(1, 100);
                        int num2 = random.Next(1, 100);
                        writer.WriteLine($"{num1} {num2}");
                    }
                }
            }
            Console.WriteLine("Генерация чисел завершена");
            generationCompleted.Set();
        }
       catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void CalcSum()
    {
        try
        {
            generationCompleted.WaitOne();
            if (!File.Exists("numbers.txt"))
            {
                Console.WriteLine("Файл numbers.txt не найден.");
                return;
            }
            lock (fileLock)
            {
                using (StreamReader reader = new StreamReader("numbers.txt"))
                using (StreamWriter writer = new StreamWriter("sum.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');
                        int num1 = Int32.Parse(parts[0]);
                        int num2 = Int32.Parse(parts[1]);
                        int sum = num1 + num2;
                        writer.WriteLine(sum);
                    }
                }
            }
            Console.WriteLine("Подсчет суммы завершен.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void CalcProductsOfNumbers()
    {
        try
        {
            generationCompleted.WaitOne();
            lock (fileLock)
            {
                using (StreamReader reader = new StreamReader("numbers.txt"))
                using (StreamWriter writer = new StreamWriter("productsofnumbers.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');
                        int num1 = int.Parse(parts[0]);
                        int num2 = int.Parse(parts[1]);
                        int product = num1 * num2;
                        writer.WriteLine(product);
                    }
                }
            }
            Console.WriteLine("Подсчет произведений завершен.");
        }
       catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
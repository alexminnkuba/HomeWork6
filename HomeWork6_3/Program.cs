internal class Program
{
    private static ManualResetEvent resetEvent = new ManualResetEvent(false);
    private static object lockObj = new object();
    private static Random random = new Random();
    private static Dictionary<int, int> passAtStop = new Dictionary<int, int>();
    private const int maxCountPassBus = 50;
    private const int simulation = 60000;
    private static List<int> busNumbers = new List<int> { 175, 17, 5 };
    private static bool flag = true;
    private static void Main(string[] args)
    {
        Thread passThread = new Thread(GenerationPassengers);
        passThread.Start();

        Thread busThread = new Thread(GenerationBus);
        busThread.Start();

        Thread arrivalBusThread = new Thread(SimulationArriveBus);
        arrivalBusThread.Start();

        Thread.Sleep(simulation);
        flag = false;
        resetEvent.Set();

        passThread.Join();
        busThread.Join();
        arrivalBusThread.Join();


        Console.WriteLine("Симуляция завершена.");
    }
    static void GenerationPassengers()
    {
        while (flag)
        {
            int newPass = random.Next(1, 10);
            int busNumber = busNumbers[random.Next(busNumbers.Count)];
            lock (lockObj)
            {
               if(passAtStop.ContainsKey(busNumber))
                {
                    passAtStop[busNumber] += newPass;
                }
               else
                {
                    passAtStop[busNumber] = newPass;
                }
                Console.WriteLine($"На остановку прибыло {newPass} пассажиров, " +
                    $"ожидающих автобус № {busNumber}. Всего на остановке: {TotalPass()}");
            }
            Thread.Sleep(random.Next(1000, 5000));
        }
    }

    static void GenerationBus()
    {
        while (flag)
        {
            resetEvent.WaitOne();
            int busNumber = busNumbers[random.Next(busNumbers.Count)];
            lock (lockObj)
            {
                if (passAtStop.ContainsKey(busNumber))
                {
                    int countPassToBus = Math.Min(passAtStop[busNumber], maxCountPassBus);
                    passAtStop[busNumber] -= countPassToBus;
                    if(passAtStop[busNumber] == 0)
                    {
                        passAtStop.Remove(busNumber);
                    }
                    Console.WriteLine($"Автобус № {busNumber} забрал {countPassToBus} пассажиров. " +
                        $"Осталось на остановке: {TotalPass()}");
                }
                 else
                {
                    Console.WriteLine($"Автобус №{busNumber} прибыл, но пассажиров для него нет. " +
                        $"Осталось на остановке: {TotalPass()}");
                }              
            }
            resetEvent.Reset();
            Thread.Sleep(random.Next(5000, 10000));
        }
    }

    static void SimulationArriveBus()
    {
        while (flag)
        {
            Thread.Sleep(random.Next(5000, 10000));
            int busNumber = busNumbers[random.Next(busNumbers.Count)];
            ArriveBus(busNumber);
        }
    }
    public static void ArriveBus(int busNumber)
    {
        resetEvent.Set();
        Console.WriteLine($"Автобус № {busNumber} прибыл на остановку!");
    }
    private static int TotalPass()
    {
        return passAtStop.Values.Sum();
    }
}
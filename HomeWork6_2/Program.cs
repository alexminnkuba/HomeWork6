internal class Program
{
    private static ManualResetEvent resetEvent = new ManualResetEvent(false);
    private static object lockObj = new object();
    private static Random random = new Random();
    private static int countPassAtStop = 0;
    private const int maxCountPassBus = 50;
    private const int simulation = 60000;
    private const int busNumber = 175;
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
            lock(lockObj)
            {
                countPassAtStop += newPass;
                Console.WriteLine($"На остановку прибыло {newPass} пассажиров. Всего на остановке: {countPassAtStop}");
            }
            Thread.Sleep(random.Next(1000, 5000));
        }
    }

    static void GenerationBus()
    {
        while(flag)
        {
            resetEvent.WaitOne();
            lock (lockObj)
            {
                int countPassToBus = Math.Min(countPassAtStop, maxCountPassBus);
                countPassAtStop -= countPassToBus;
                Console.WriteLine($"Автобус № {busNumber} забрал {countPassToBus} пассажиров. Осталось на остановке: {countPassAtStop}");
            }
            resetEvent.Reset();
            Thread.Sleep(random.Next(5000, 10000));
        }        
    }
    static void SimulationArriveBus()
    {
        while(flag)
        {
            Thread.Sleep(random.Next(5000, 10000));
            ArriveBus();
        }
    }
    public static void ArriveBus()
    {
        resetEvent.Set();
        Console.WriteLine($"Автобус № {busNumber} прибыл на остановку!");
    }
}
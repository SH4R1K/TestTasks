using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            FailProcess();
        }
        catch { }

        Console.WriteLine("Failed to fail process!");
        Console.ReadKey();
    }

    static void FailProcess()
    {
        // Вариант 1 - закрытие консоли
        Environment.Exit(0);
        // Вариант 2 - схожее решение
        Process process = Process.GetCurrentProcess();
        process.Kill();
        // Вариант 3 - stackoverFlow
        FailProcess();
    }
}

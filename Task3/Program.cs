using Task3;

class Program
{
    private static void Main(string[] args)
    {
        var a = new[] { 1, 2, 3, 4, }.EnumerateFromTail(2);
        foreach (var x in a)
        {
            Console.WriteLine(x);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        TransformToElephant();
        Console.WriteLine("Муха");
        //... custom application code
    }

    static void TransformToElephant()
    {
        Console.WriteLine("Слон");
        Console.SetOut(TextWriter.Null); // Отключаем отображение вывода, чтобы пользователь не увидел муху
    }
}
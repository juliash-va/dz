class Programm
{
    static int F(int x)
    {
        if (x % 2 == 0) return x / 2;
        else return 0;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Измененное число: {F(a)}");
    }
}
class Programm
{
    static int F(int x)
    {
        if (x % 5 == 0) return x / 5;
        else return x += 1;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Измененное число: {F(a)}");
    }
}
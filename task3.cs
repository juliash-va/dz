class Programm
{
    static int F(int x)
    {
        if (x >= 10 && x <= 99)
        {
            string units = (x % 10).ToString();
            string tens = (x / 10).ToString();
            x = Convert.ToInt32(units + tens);
            return x;
        }
        else return x;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Измененное число: {F(a)}");
    }
}
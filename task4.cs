class Programm
{
    static int F(int x)
    {
        if (x >= 100 && x <= 999)
        {
            int tens1 = x / 10;
            string hundred = (x / 100).ToString();
            string tens = (tens1 % 10).ToString();
            string units = (x % 10).ToString();

            x = Convert.ToInt32(units + tens + hundred);

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
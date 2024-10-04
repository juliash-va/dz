class Programm
{
    static double F(double x, double y, double z)
    {
        z = Math.Pow((y * y + x * x), 0.5);
        z = Math.Round(z, 2);
        return x + y + z;
    }
    static void Main(string[] srgs)
    {
        Console.Write("Введите первый катет: ");
        int k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второй катет: ");
        int k2 = Convert.ToInt32(Console.ReadLine());
        int z = 0;

        Console.WriteLine($"Периметр треугольника равен: {F(k1, k2, z)}");
    }
}
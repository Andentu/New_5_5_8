namespace New_5_5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("\nВведите степень, в которую нужно возвести число: ");
            byte power = byte.Parse(Console.ReadLine());
            PowerUp(num, power);
            Console.Write("\nРезультат: " + PowerUp(num, power));

            Console.ReadKey();
        }
        private static decimal PowerUp(decimal N, byte pow)
        {
            // decimal result;
            if (pow == 0)
            {
                return 1;
            }
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow); // N * на N столько раз, сколько указано в pow
            }

        }
    }
}
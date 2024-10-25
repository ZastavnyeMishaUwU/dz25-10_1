namespace dz25_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ваше ім'я: ");
            string name = Console.ReadLine();
            Console.Write("Введіть час доби (у годинах): ");
            int hour = int.Parse(Console.ReadLine());
            string greeting;

            if (hour < 12)
            {
                greeting = "Доброго ранку";
            }
            else if (hour < 18)
            {
                greeting = "Добрий день";
            }
            else
            {
                greeting = "Добрий вечір";
            }
            Console.WriteLine($"{greeting}, {name}!");
        }
    }
}

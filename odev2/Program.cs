namespace odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Başlangıç Sayısı:");
            byte bas = byte.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş Sayısı:");
            byte bit = byte.Parse(Console.ReadLine());

            Console.WriteLine("Sayı Adeti:");
            byte adet = byte.Parse(Console.ReadLine());


            int[] numbers = new int[adet];
            int num;
            for (int i = 0; i < numbers.Length; i++)
            {
                num = rnd.Next(bas, bit);
                if (i == 0)
                {
                    numbers[i] = num;
                }
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == num)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = num;
                    }
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

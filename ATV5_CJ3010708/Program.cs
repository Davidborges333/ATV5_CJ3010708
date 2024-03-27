namespace ATV5_CJ3010708
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, temp;
            int soma = 0;

            for (a = 0; a < 3; a ++) {
                Console.WriteLine("Digite um valor");
                temp = int.Parse(Console.ReadLine());
                if (temp < 0)
                    break;
                soma = soma + temp;
            }
            Console.WriteLine("A média é {0}", soma / 3);
        }
    }
}



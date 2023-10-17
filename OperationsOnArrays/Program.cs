using System.Linq.Expressions;

namespace OperationsOnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu numarul de elemente ale array-ului: ");

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array-ul este: { ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("}");

            Console.WriteLine("Elementul maxim este: " + ElementMaxim(numbers));
            Console.WriteLine("Suma elementelor este: " + SumaElementelor(numbers));
            Console.WriteLine("Media elementelor este: " + MediaElementelor(numbers));
            Console.Write("Array-ul invers este: { ");
            VectorInversat(numbers);
            Console.WriteLine("}");

            Console.Write("Introdu elementul pe care il cauti: ");
            int frecventa = int.Parse(Console.ReadLine());
            Console.WriteLine("Elementul " + frecventa + " apare de " + CalculFrecventa(numbers, frecventa) + " ori in array.");
        }

        static int ElementMaxim(int[] numbers)
        {
            int maxim = 0;

            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] > maxim) maxim = numbers[i];  
            }

            return maxim;
        }

        static int SumaElementelor(int[] numbers)
        {
            int suma = 0;

            for(int i = 0; i<numbers.Length; i++)
            {
                suma += numbers[i];
            }

            return suma;
        }

        static float MediaElementelor(int[] numbers)
        {
            float media = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                media += numbers[i];
            }

            media /= numbers.Length;

            return media;
        }

        static void VectorInversat(int[] numbers)
        {
            int[] invers = new int[numbers.Length];
            int ctInvers = numbers.Length - 1;
            int ct = 0;

            while (ct < numbers.Length)
            {
                invers[ct] = numbers[ctInvers];

                Console.Write(invers[ct] + " ");

                ct++;
                ctInvers--;
            }

        }

        static int CalculFrecventa(int[] numbers, int element)
        {
            int frecventa = 0;

            for(int i= 0; i<numbers.Length; i++)
            {
                if (numbers[i] == element) frecventa++;
            }

            return frecventa;
        }
    }
}
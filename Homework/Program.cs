using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Base;
class Program
{
    static void Main()
    {
        int max = 1000000000;
        int min = 0;
        Random random = new Random();
        int tech = random.Next(min, max);
        int count = 0;
        int guess;
        while (true)
        {
            guess = (max - min) / 2 + min;
            count = count + 1;
            Console.WriteLine($"Попытка {count}");
            if (guess > tech)
            {
                max = guess;
                Console.WriteLine($"Слишком высоко, пробуй ещё, следующая попытка {guess}");
            }
            else if (guess < tech)
            {
                min = guess;
                Console.WriteLine($"Слишком низко, пробуй ещё, следующая попытка {guess}");
            }
            else
            {

                break;
            }
        }
        Console.WriteLine($"Красавчик, угадал, число было {tech}, число попыток {count}");
    }
}



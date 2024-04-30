
namespace ConsoleDZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Введите первое число");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число, которое меньше А и В");
            int C = Convert.ToInt32(Console.ReadLine());
            int D = ((A /C) * (B /C));
            Console.WriteLine("Количество квадратов со стороной С в прямоугольнике АВ равно" + " " + D);
            Console.WriteLine("Площадь незанятой части равна" + " " + ((A * B) - (C * C * D)));
            
            Console.WriteLine("Задача 2");
            int n = 10000;
            Console.WriteLine("Введите месячную ставку от 0 до 25");
            double P = double.Parse(Console.ReadLine());
            int a = 0;
            double S = 0;
            do
            {
                a++;
                S = n * (Math.Pow((1 + P / 100), a));
            }
            while (S < 11000);
            Console.WriteLine("Сумма вклада составила " + S + "руб.");
            Console.WriteLine("Количество месяцев: " + a);



            Console.WriteLine("Задача 3");
            Console.WriteLine("Введите два числа");
            int F = Convert.ToInt32(Console.ReadLine()); 
            int J = Convert.ToInt32(Console.ReadLine());
            if ( F < J) {
                for (; F<= J; F++)
                {
                    for (int i = 0; i < F; i++) Console.Write(F);
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Число А не меньше В");


            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите число");
            string s = Console.ReadLine(); 
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new String(arr);
            int resalt = int.Parse(s);
            Console.WriteLine(resalt);


        }
    }
}

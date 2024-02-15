internal class Program
{
    private static void Main(string[] args)
    {
        for (; ; )
        {
            Console.WriteLine("Значение переменной 1:");
            var first = Console.ReadLine();
            Console.WriteLine("Значение переменной 2:");
            var second = Console.ReadLine();
            Console.WriteLine("Знак действия:");
            string sign = Console.ReadLine();
            try
            {
                int.Parse(first);
                int.Parse(second);
                Console.WriteLine("Результат:");
                Console.WriteLine(Calc<int>(Convert.ToInt32(first), Convert.ToInt32(second), sign));

            }
            catch (Exception)
            {
                try
                {
                    double.Parse(first);
                    double.Parse(second);
                    Console.WriteLine("Результат:");
                    Console.WriteLine(Calc<double>(Convert.ToDouble(first), Convert.ToDouble(second), sign));
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: использована переменная нечисленного типа!");
                }
            }
            Console.ReadKey();
        }


        object Calc<T>(T first, T second, string sign)
        {
            switch (sign)
            {
                case "+":
                    return Sum<T>(first, second);
                case "-":
                    return Diff<T>(first, second);
                case "*":
                    return Multi<T>(first, second);
                case "/":
                    return Div<T>(first, second);
            }

            return "Ошибка: знак действия некорректен!";
        }
        object Sum<T>(T sum1, T sum2)
        {
            dynamic x = sum1;
            dynamic y = sum2;
            return x + y;
        }
        object Diff<T>(T diff1, T diff2)
        {
            dynamic x = diff1;
            dynamic y = diff2;
            return x - y;
        }
        object Multi<T>(T multi1, T multi2)
        {
            dynamic x = multi1;
            dynamic y = multi2;
            return x * y;
        }
        object Div<T>(T div1, T div2)
        {
            dynamic x = div1;
            dynamic y = div2;
            if (y == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            return x / y;
        }
    }
}
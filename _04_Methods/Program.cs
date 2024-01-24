namespace _04_Methods;

public static class Program
{
    public static void Main(string[] args)
    {
        #region Методы

        // Функции в языке C# называются методами
        // void - это ключевое слово, используемое для указания, что метод не возвращает значение.
        void DoSomething()
        {
            // logic
        }

        // Методы могут принимать параметры
        void PringNumbers(int num1, int num2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        // Методы могут возвращать значения
        int GetSum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }

        #endregion

        #region Ref
        
        // Ключевое слово ref указывает, что аргумент передаётся по ссылке
        int ChangeNumber(ref int num1)
        {
            num1 = num1 + 1;
            return num1;
        }

        var number = 5;
        ChangeNumber(ref number);
        Console.WriteLine(number);

        #endregion

        #region Out

        // Ключевое слово ref указывает, что аргумент передаётся по ссылке
        bool TrySumNumbers(int num1, int num2, out int sum)
        {
            sum = num1 + num2;
            return true;
        }

        var number1 = 5;
        var number2 = 10;
        TrySumNumbers(number1, number2, out int result);
        Console.WriteLine(result);

        #endregion

        #region Params

        int SumNumbers(params int[] args)
        {
            return args.Sum();
        }

        SumNumbers();
        SumNumbers(2,3);
        SumNumbers(12, 55, 152, 2);
        SumNumbers(1231, 241, 123, 5);

        #endregion
    }
}
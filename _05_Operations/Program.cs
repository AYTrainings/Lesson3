namespace _05_Converting;

public static class Program
{
    public static void Main(string[] args)
    {
        #region Арифметика

        {
            int x = 10;
            int y = 5;

            // + Операция сложения
            int sum = x + y; // 15

            // - Операция вычитания
            int difference = x - y; // 5

            // / операция деления
            int quotient = x / y; // 2

            // * операция умножения
            int multiplication = x * y; // 50

            // % Операция получение остатка от целочисленного деления
            int remainder = 10 % 4; // 2

            // ++ Операция инкремента
            int z = 1;
            z++;
            ++z;

            // -- Операция декремента или уменьшения значения на единицу
            int w = 5;
            w--;
            --w;


            // Префиксный инкремент: ++x - сначала значение переменной x увеличивается на 1, а потом ее значение
            // возвращается в качестве результата операции.

            // Постфиксный инкремент: x++ - сначала значение переменной x возвращается в качестве результата операции, а
            // затем к нему прибавляется 1.

            // !!!ВАЖНО
            int result = 10 / 5 * 2; // ?
            // Все арифметические операторы (кроме префиксного инкремента и декремента) являются левоассоциативными!
            // Это значит, что они выполняюся слева направо

            // !!!ВАЖНО
            // Операции присвоения имеют низкий приоритет
            int a, b, c;
            a = b = c = 34 * 2 / 4; // 17
        }

        #endregion

        #region Дополнительные операции присвоения

        // +=: присваивание после сложения. Присваивает левому операнду сумму левого и правого операндов:
        // выражение A += B равнозначно выражению A = A + B
        int value1 = 5;
        value1 += 5;
        //value1 = value1 + 5;

        //Console.WriteLine(value1);

        // -=: присваивание после вычитания. Присваивает левому операнду разность левого и правого операндов:
        // A -= B эквивалентно A = A - B
        int value2 = 5;
        value2 -= 5;
        //Console.WriteLine(value2);

        // *=: присваивание после умножения. Присваивает левому операнду произведение левого и правого операндов:
        // A *= B эквивалентно A = A * B
        int value3 = 5;
        value3 *= 5;
        //Console.WriteLine(value3);

        // /=: присваивание после деления. Присваивает левому операнду частное левого и правого операндов: A /= B
        // эквивалентно A = A / B
        int value4 = 5;
        value4 /= 5;
        //Console.WriteLine(value4);

        #endregion

        #region Преобразование (Casting)

        // Расширяющие (widening)
        // В данном случае происходит неявные преобразования (explicit conversion)
        byte byteVal1 = 55;
        int intVal1 = byteVal1;


        // Сужающие (narrowing)
        int intVal2 = 55;
        // byte byteVal2 = intVal2; // - Ошибка. Необходимо использовать каст
        // Это называется явным преобразованием (перед значением указывается в скобках тип, к которому надо привести данное значение)
        byte byteVal2 = (byte)intVal2;

        // byte a = 4;
        // int b = a + 70; // 74
        //
        // byte a = 4;
        // byte b = a + 70; // ОШИБКА
        //
        // byte a = 4;
        // byte b = (byte)(a + 70);
        //
        // byte a = 4;
        // int b = a + 70; // 74
        //
        // byte a = 4;
        // byte b = a + 70; // ОШИБКА
        //
        // byte a = 4;
        // byte b = (byte)(a + 70);

        #endregion

        #region Checked & UnChecked (Переполнение)

        {
            int a = 255;
            int b = 2;
            byte byteValue1 = unchecked((byte)(257));
            Console.WriteLine(byteValue1); // = 1, произойдёт переполнение

            // При использовании ключевого слова checked
            // приложение выбрасывает исключение о переполнении:
            try
            {
                int x = 33;
                int y = 600;
                byte z = checked((byte)(a + b));
                //Console.WriteLine(z);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Конвертирование типов

        // Класс Convert в C# предоставляет статические методы для преобразования значений между различными типами данных. 
        int intValue = Convert.ToInt32("123");
        double doubleValue = Convert.ToDouble("3.12");
        bool booleanValue = Convert.ToBoolean("True");

        // Console.WriteLine(intValue);
        // Console.WriteLine(doubleValue);
        // Console.WriteLine(booleanValue);

        // Если конвертация невозможна - будет ошибка выполнения!!!
        //var booleanValue2 = Convert.ToBoolean("123"); // --- ОШИБКА!
        int intValueFromDouble = Convert.ToInt32(1.5); // =2 

        // Другой способ
        bool intParsingResult = int.TryParse("123", out int int1); // true, int1=123;
        bool doubleParsingResult = double.TryParse("123.123", out double double1); // true, double1=123.123;
        bool boolParsingResult = bool.TryParse("123", out bool bool1); // true, bool1=false;


        #endregion

        #region Boxing & UnBoxing

        {
            // Упаковка представляет собой процесс преобразования типа значения в тип object. Когда тип значения
            // упаковывается общеязыковой средой выполнения (CLR), он инкапсулирует значение внутри экземпляра
            // System.Object и сохраняет его в управляемой куче. Операция распаковки извлекает тип значения из объекта.
            // Упаковка является неявной; распаковка является явной. 
                
            // BOXING
            int a = 55;
            object b = (object)a;
            // object b = a; - Так тоже можно, т.к. боксинг неявный
            
            // UNBOXING
            int c = (int)b;
        }

        #endregion
    }
}
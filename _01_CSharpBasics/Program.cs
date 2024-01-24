namespace _01_CSharpBasics;

#region Summary class section

/// <summary>
/// Этот класс создан для демонстрации summary комментариев
/// Такие комментарии используются для документирования
/// </summary>
public static class Comment
{
    /// <summary>
    /// Функция преобразует целочисленный аргумент в строку
    /// </summary>
    /// <param name="arg">Это целочисленный аргумент</param>
    /// <returns>Результатом является строка</returns>
    public static string Function(int arg)
    {
        return arg.ToString();
    }
}

#endregion

public static class Program
{
    static int intval = 5;
    public static void Main(string[] args)
    {
        #region Переменные

        // Variable (Переменная) - это область памяти, которая хранит в себе значение.

        // Мы создаем переменную с именем number, которая является типом int и присваиваем ей значение 7.
        int number = 7;

        // Мы создаем переменную с именем text, которая является типом string и присваиваем ей значение 7.
        string text = "Hello";

        #endregion

        #region Константы

        // Константа - это область памяти, которая хранит в себе некоторое значение, которое нельзя изменить.
        const int firstNumber = 1;
        const double pi = 3.141;
        const int footballPlayersCount = 11;
        const string applicationName = "Telegram";

        // footballPlayersCount = 5; // - Вызовет ошибку. Константы нельзя изменять
        
        #endregion
        
        #region Литералы

        // Литерал - это представление фиксированного значения в исходном коде программы.
        // Литералы используются для инициализации переменных и констант. 

        // Целочисленные литералы:
        // В десятичной форме
        Console.WriteLine(-11);
        Console.WriteLine(5);
        Console.WriteLine(505);

        //В двоичной форме
        Console.WriteLine(0b11); // 3
        Console.WriteLine(0b1011); // 11
        Console.WriteLine(0b100001); // 33

        //В шестнадцатеричной форме
        Console.WriteLine(0x0A); // 10
        Console.WriteLine(0xFF); // 255
        Console.WriteLine(0xA1); // 161

        // Вещественные литералы:
        Console.WriteLine(3.14);
        Console.WriteLine(100.001);
        Console.WriteLine(-0.38);

        // Вещественные литералы в экспоненциальной форме MEp, где M — мантисса, E - экспонента
        Console.WriteLine(3.2e3); // = 3.2 * 10 в степени 3 = 3200
        Console.WriteLine(1.2E-1); // = 1.2 * 10 в степени -1 = 0.12

        // Логические литералы
        Console.WriteLine(true); // bool
        Console.WriteLine(false); // bool

        // Литералы символов и строк
        Console.WriteLine('A'); // char
        Console.WriteLine("Hello, World!"); // string
            
        // Шестнадцатеричные коды ASCII
        Console.WriteLine('\x5A'); // Z
        
        // Коды символов из таблицы символов Unicode
        Console.WriteLine('\u0057'); // W
        Console.WriteLine('\u0058'); // X
        Console.WriteLine("\u0059\u0069\u0079\u0078\u0019\u0029"); // Строка: Yiyx↓)

        // Управляющие последовательности
        // ‘\n' - перевод строки
        // ‘\t' - табуляция
        // ‘\'  - экранирование

        Console.WriteLine("Hello, \n world!!!");
        Console.WriteLine("Hello, \t world!!!");
        Console.WriteLine("Hello, \"world!!!\"");

        #endregion

        #region Комментарии

        // Это однострочный комментарий

        /*Это
        многострочный
        комментарий*/

        // TODO: Это todo комментарий


        // Summary комментарии
        Comment.Function(5);

        #endregion

        #region Область видимости

        
        //int number1 = 5;

        //{
        //    int number2 = 10;
        //    number1 = 7;
        //}

        //number2 = 11;
        

        #endregion

        #region Консоль

        Console.Write("Name");
        Console.WriteLine("Name");
        int symbol = Console.Read();
        string string5 = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Введите символ");
        int keyFromConsole = Console.Read();

        Console.WriteLine("Введите строку");
        string textFromConsole = Console.ReadLine();

        #endregion

        #region Алиасы

        // алиас (псевдоним)
        byte alliasByte = 2;

        // Системный тип
        Byte systemByte = 2;

        #endregion

        #region Регистр

        // C# является регистрозависимым языком
        int variable = 5;
        int vaRiable = 5;
        // variable != vaRiable

        #endregion
    }
}
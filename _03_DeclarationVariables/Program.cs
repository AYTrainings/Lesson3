using static _03_DeclarationVariables.Program;

namespace _03_DeclarationVariables;

public static class Program
{
    public static void Main(string[] args)
    {
        #region Инициализация

        // Если не присваеваем значение, пользоваться этими переменными не сможем
        byte byte1;
        bool bool1;
        char char1;
        string string1;


        // У всех значимых типов есть значение по умолчанию.
        // У ссылочных типов значение по умолчанию - null.
        char defaultChar = default; // '\0'
        int defaultInt = default; // 0
        bool defaultBool = default; // False
        byte defaultByte = default; // 0
        sbyte defaultSByte = default; // 0
        short defaultShort = default; // 0
        ushort defaultUShort = default; // 0
        uint defaultUInt = default; // 0
        long defaultLong = default; // 0
        ulong defaultULong = default; // 0
        float defaultFloat = default; // 0.0
        double defaultDouble = default; // 0.0
        decimal defaultDecimal = default; // 0.0

        // Суффикс позволяет указать компилятору тип
        float float1 = 0.12345678901234567890F;
        double double1 = 0.12345678901234567890D;
        decimal decimal1 = 0.12345678901234567890M;

        // Символ
        char char3 = 'B';

        // Формат-16
        char char4 = '\x0041';

        // unicode-формат
        char char5 = '\u0041';

        #endregion

        #region Неявная типизация

        // Неявная типизация
        var var1 = 0.12345678901234567890f;
        var var2 = 0.12345678901234567890d;
        var var3 = 0.12345678901234567890m;
        var var4 = "stext";
        var var5 = true;
        
        // При явной инициализации, мы можем не присваивать значение
        int intValue;
        intValue = 20;


        // При неявной типизации мы не можем не присвоить значение, т.к компилятор должен знать тип.
        // var someValue; -- ОШИБКА КОМПИЛЯЦИИ
        // someValue = 20;
        // var value = null; -- ОШИБКА КОМПИЛЯЦИИ
        #endregion
    }
}
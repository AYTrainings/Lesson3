namespace _06_Conditionals;

class Program
{
    static void Main(string[] args)
    {
        #region Операции сравнения

        {
            // Операции сравнения
            // Это операции возвращающие логическое значение (значение типа bool: true, false)
            // == Сравнивает два операнда на равенство
            // != Сравнивает два операнда на неравенство
            // Операции <, > <=, >=

            // Пример:
            int x = 5;
            int y = 10;
            Console.WriteLine(x == y); // = FALSE
            Console.WriteLine(x != y); // = TRUE
            Console.WriteLine(x > y); // = FALSE
            Console.WriteLine(x >= y); // = FALSE
            Console.WriteLine(x < y); // = TRUE
            Console.WriteLine(x <= y); // = TRUE
        }

        #endregion

        #region Логические операции

        {
            // В качестве операндов логические операции принимают значения типа bool.

            // ИЛИ
            // | Операция логического сложения или логическое ИЛИ. Возвращает true, если хотя бы один из
            //   операндов возвращает true.
            // || Операция логического сложения (С ЗАМЫКАНИЕМ). Возвращает true, если хотя бы один из операндов возвращает true.

            int x = 5;
            int y = 5;
            bool result3 = (x == 5) || (y == 6); // TRUE
            bool result4 = (x == 5) | (y == 6); // TRUE

            // & Операция логического умножения или логическое И. Возвращает true, если оба операнда
            //   одновременно равны true.
            // && Операция логического умножения (С ЗАМЫКАНИЕМ). Возвращает true, если оба операнда одновременно равны true.

            bool result1 = (x == 5) && (y == 5); // TRUE
            bool result2 = (x == 5) & (y == 5); // TRUE

            // ! Операция логического отрицания. Производится над одним операндом и возвращает true, если
            //   операнд равен false.
            bool result5 = !(x == 5); // FALSE
            bool result6 = !(x == 6); // TRUE
        }

        #endregion

        #region Условная конструкция If/else

        {
            // Конструкция if/else проверяет истинность условия и в зависимости от результатов проверки выполняет
            // определенный код
            int x = 11;
            if (x > 10)
            {
                Console.WriteLine("123");
            }
            else 
            {
                if (x > 5)
                {
                    // Если условие != TRUE - выполнится этот блок
                    // Блок Else может отсутствовать
                }
                else
                {

                }
            } 




            
            // Соединение сразу несколько условий
            int num1 = 8;
            int num2 = 6;
            if(num1 > num2 && num1==8)
            {
                // Если условие == TRUE - выполнится этот блок
            }
        }

        #endregion
        
        #region Условная конструкция Switch-case

        Console.WriteLine("Нажмите Y или N");
        string selection = Console.ReadLine();

        switch (selection)
        {
            case "5":
            case "6":
            case "Y":
                Console.WriteLine("Вы нажали букву Y");
                break;
            case "N":
                Console.WriteLine("Вы нажали букву N");
                break;
            case "ABCD":
                Console.WriteLine("Вы нажали AVBCS");
                break;
            default:
                Console.WriteLine("Вы нажали неизвестную букву");
                break;
        }
        
        // ● Как правило, используется оператор break. При его применении другие блоки case выполняться не будут.
        // ● Если мы хотим, чтобы, наоборот, после выполнения текущего блока case выполнялся другой блок case, то
        //   мы можем использовать вместо break оператор goto case.
        // ● Если мы хотим также обработать ситуацию, когда совпадения не будет найдено, то можно добавить блок
        //   default.
        // ● Применение оператора return позволит выйти не только из блока case, но и из вызывающего метода.
        // ● Оператор throw применяется для выброса ошибок.
        
        Console.WriteLine("Введите exit, чтобы покинуть программу");
        string enteredText = Console.ReadLine();
        switch (enteredText)
        {
            case "Exit":
                Console.WriteLine("ВЫХОД");
                break;
            default:
                Console.WriteLine("ПРОДОЛЖАЕМ");
                break;
        }

        #endregion

        #region Тернарная операция

        {
            // Тернарная операция является синтаксическим сахаром, компилятор разворачивает её условную конструкцию

            // УСЛОВИЕ ? ТО : ИНАЧЕ

            int x = 5;
            int y = 10;
            int c = IsConnectionEnabled() ? GetOne() : (x < 10 ? 5 : 21); // c = 22;



            bool IsConnectionEnabled()
            {
                return true;
            }

            int GetOne() { return 1; }
            int Gettwo() { return 2; }











            int d = x > y ? 22 : 55; // c = 55;
        }
        
        #endregion
    }
}
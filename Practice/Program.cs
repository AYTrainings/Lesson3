﻿namespace Practice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число 1");
        string input1 = Console.ReadLine();
        int number1 = Convert.ToInt32(input1);

        Console.WriteLine("Введите число 2");
        string input2 = Console.ReadLine();
        int number2 = Convert.ToInt32(input2);

        Console.WriteLine("Результат:");
        int result = number1 + number2;
        Console.WriteLine(result);

        // 1. Сложение чисел:
        // Попросите пользователя ввести два числа.
        // Выведите результат их сложения.

        // 2. Среднее арифметическое:
        // Попросите пользователя ввести два числа.
        // Вычислите и выведите среднее арифметическое этих чисел.

        // 3. Определение четности числа:
        // Попросите пользователя ввести число.
        // Проверьте, является ли число четным или нечетным, и выведите соответствующее сообщение.

        // 4. Оценка студента:
        // Попросите пользователя ввести оценку от 0 до 100.
        // Используйте условные операторы для выдачи оценки: "Отлично", "Хорошо", "Удовлетворительно" или "Неудовлетворительно".

        // 5. Генератор случайного числа:
        // Сгенерируйте случайное число.
        // Попросите пользователя угадать это число, предоставив ему подсказки (больше/меньше).




















        // Домашнее задание:
        // 1. Написать программу для вывода названия поры года по
        //    номеру месяца.
        //    При решении используйте оператор switch-case.
        // 2. Написать программу для вывода названия поры года по номеру
        // месяца.
        //    При решении используйте оператор if-else-if.
        // 3. Напишите программу, которая будет принимать на вход число и на
        // выход будет выводить сообщение четное число или нет.
        //    Для определения четности числа используйте операцию получения остатка от деления - операция выглядит так: '% 2').
        // 4. Для введенного числа t (температура на улице) вывести
        //    Если t>–5, то вывести «Тепло».
        //    Если –5>= t > –20, то вывести «Нормально».
        //    Если –20>= t, то вывести «Холодно».
        // 5. По введенному номеру определить цвет радуги (1 –красный, 4 – зеленый и т. д.).
    }
}
/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = ReadInt("Input Three-digit number: ");

    Console.WriteLine(SecondNum(number));

// Cообщение для отображения в консоли,введенного значения пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Вывод второй цифры трехзначного числа.
int SecondNum(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = ReadInt("Input number: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

//Cообщение для отображения в консоли,введенного значения пользователем.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
   
    }
    return " день.";
}
*/

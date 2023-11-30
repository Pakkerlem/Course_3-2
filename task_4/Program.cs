// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int tem = 0;
// if (num >= 0)
// {
//     do 
//     {
//         Console.Write(" ");
//         num = num - num %10;  
//     }
//     while
// }
// else
// {
//    Console.Write("Число не натуральное");
// }


Console.WriteLine("Введите натуральное число:");
if (int.TryParse(Console.ReadLine(), out int number))
{
    DisplayDigits(number);
}
else
{
    Console.WriteLine("Ошибка! Введено некорректное значение.");
}
    

    static void DisplayDigits(int n)
{
    if (n < 0)
    {
        n = -n;
    }

    string digits = n.ToString();
    for (int i = 0; i < digits.Length; i++)
    {
        Console.Write(digits[i]);
        if (i != digits.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}
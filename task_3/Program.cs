// Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10 && number <= 99)
{
    int last = number % 10;
    int first = number / 10;

    if (first > last)
    {
        Console.WriteLine(first);
    }
    else
    {
        Console.WriteLine(last);
    }

}
else
{
    Console.WriteLine("Число не соответсвует требованиям");
}
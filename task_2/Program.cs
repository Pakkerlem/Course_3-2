// Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.


do
{
    Console.WriteLine("Введите число координату X и Y:");
    int Xcor = Convert.ToInt32(Console.ReadLine());
    int Ycor = Convert.ToInt32(Console.ReadLine());

    if (Xcor == 0 || Ycor == 0)
    {
        Console.WriteLine("Вы ввели недопустимое значение. X = 0 или Y = 0 Попробуйте еще раз.");
    }
   
    else
    {
         if (Xcor > 0 && Ycor > 0) Console.WriteLine("1");
         if (Xcor < 0 && Ycor > 0) Console.WriteLine("2");
         if (Xcor < 0 && Ycor < 0) Console.WriteLine("3");
         if (Xcor > 0 && Ycor < 0) Console.WriteLine("4");
         break;
    }

} while (true);
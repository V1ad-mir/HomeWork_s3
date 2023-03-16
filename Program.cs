// // Задача 19

// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // Example:
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// Console.Write("Введите ");
// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("пятизначное число");
// Console.ResetColor();
// string number = Console.ReadLine();
// int num;
// if ((int.TryParse(number, out num)))
// {
//    int cycle = number.Length/2;
//    int i=0;
//    int result=0;
//    while (i<cycle)
//    {
//         if (number[i]==number[number.Length-1-i])
//        {
//        result++;
//        }
//        else
//        {
//        result=0;
//        }
//     i++;
//     }
    
      
//        if (result==number.Length/2)
//         {
//          Console.WriteLine(number+" являеться палиндромом ");
//         }
//          else
//         {
//         Console.WriteLine(number+" не являеться палиндромом ");
//         }
// }
// else 
//   {
//     Console.Write("При вводе числа допущена ");
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine("ОШИБКА");
//     Console.ResetColor();
//   }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите X для точки А");
// int XA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y для точки А");
// int YA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z для точки А");
// int ZA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите X для точки B");
// int XB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y для точки B");
// int YB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z для точки B");
// int ZB = Convert.ToInt32(Console.ReadLine());
// double number =Math.Sqrt(Math.Pow((XB-XA),2)+Math.Pow((YB-YA),2)+Math.Pow((ZB-ZA),2));
// Console.Write("Расстояние между точаками :"+number);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=number; i++)
{
 Console.Write(Math.Pow(i,3)+" "); 
}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.SetWindowSize(40, 40);
//        Console.SetBufferSize(40, 40);

//        char userChar = '0';
//        Console.WriteLine($"На экране будет нарисован ромб из символа '{userChar}'.");

//        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
//        Console.ReadKey();

//        Console.Clear();
//        Console.BackgroundColor = ConsoleColor.White;
//        Console.Clear();
//        Console.ForegroundColor = ConsoleColor.DarkGray;

//        DrawDiamond(userChar, 13, 7);

//        Console.ResetColor();
//        Console.WriteLine("Нажмите любую клавишу для выхода...");
//        Console.ReadKey();
//    }

//    static void DrawDiamond(char ch, int height, int width)
//    {
//        int mid = width / 2;
//        int centerY = height / 2;

//        for (int i = 0; i <= centerY; i++)
//        {
//            int spaces = mid - i;
//            int count = 1 + 2 * i;

//            if (spaces >= 0)
//            {
//                Console.SetCursorPosition(spaces, i);
//                Console.WriteLine(new string(ch, count));
//            }
//        }

//        for (int i = centerY - 1; i >= 0; i--)
//        {
//            int spaces = mid - i;
//            int count = 1 + 2 * i;

//            if (spaces >= 0)
//            {
//                Console.SetCursorPosition(spaces, centerY + (centerY - i));
//                Console.WriteLine(new string(ch, count));
//            }
//        }
//    }
//}
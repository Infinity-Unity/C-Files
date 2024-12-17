using System;
using System.Media;


class Program
{
   

    static void Main(string[] args)
    {
        
        DrawBar(5, 10, ConsoleColor.Red, 7);
        DrawBar(5, 10, ConsoleColor.Blue, 8);

    }


    static void DrawBar(int value,int MaxValue,ConsoleColor color,int position)
    {
        ConsoleColor defaultColor = Console.BackgroundColor;
        string bar = "";

        for(int i = 0;i < value;i++)
        {
            bar += " ";
        }

        Console.SetCursorPosition(0, position);
        Console.Write('[');
        Console.BackgroundColor = color;
        Console.Write(bar);
        Console.BackgroundColor = defaultColor;



        bar = "";



        for(int j = value;j < MaxValue;j++)
        {
            bar += " ";
        }
        Console.WriteLine(bar + ']');




    }
    

    


    
}
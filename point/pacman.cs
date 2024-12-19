using System;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    


    static void Main(string[] args)
    {
        
        Console.CursorVisible = false;
        int score = 0;

        bool isOpen = true;

        int playerPositionX = 1;
        int playerPositionY = 1;
        char[,] map = ReadMap("map.txt");


        ConsoleKeyInfo press = new ConsoleKeyInfo('w',ConsoleKey.W,false,false,false);
        Task.Run(() => {
            while (true)
            {
                press = Console.ReadKey();
            }
           
        });
        
        while(isOpen)
        {
            
            
            PlayerController(press,ref playerPositionX,ref playerPositionY,map,ref score);
            Console.SetCursorPosition(0, 20);
            Console.Write("Score: " + score);
            Console.SetCursorPosition(0, 0);
            DrawMap(map);
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write('@');//player
            Thread.Sleep(3);
            
            
            
        }
        



    }

    private static char[,] ReadMap(string path)
    {
        
        string[] fileMap = System.IO.File.ReadAllLines(path);
        char[,] map = new char[fileMap.Length, fileMap[0].Length];
        for (int i = 0; i < fileMap.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                map[i, j] = Convert.ToChar(fileMap[i][j]);
            }
            
        }
        return map;
    }
    private static void DrawMap(char[,] map)
    {
        for(int i = 0;i < map.GetLength(0); i++)
        {
            for(int j =0 ;j < map.GetLength(1);j++)
            {
                Console.Write(map[i,j]);
            }
            Console.WriteLine();
        }
    }
    private static void PlayerController(ConsoleKeyInfo pressedKey,ref int posX,ref int posY, char[,] map,ref int score)
    {
        int newX = posX;
        int newY = posY;

        switch (pressedKey.Key)
        {
            case ConsoleKey.UpArrow:
                newY--;
                break;
            case ConsoleKey.DownArrow:
                newY++;
                break;
            case ConsoleKey.LeftArrow:
                newX--;
                break;
            case ConsoleKey.RightArrow:
                newX++;
                break;
        }

      
        if (newX >= 0 && newX < map.GetLength(1) && newY >= 0 && newY < map.GetLength(0))
        {
            
            if (map[newY, newX] != '#')
            {
                posX = newX;
                posY = newY;
            }
        }
        if (map[newY,newX] == '*')
        {
            map[newY, newX] = ' ';
            
            score++;
            
        }
    }
    
}

    
    
    

    


    

using System;
using System.Media;


class Program
{
    static void Main(string[] args)
    {


        Console.CursorVisible = false;
        bool isOpen = true;
        bool isWin = false;
        ConsoleColor std = Console.ForegroundColor;
        int userPositionX = 1;
        int userPositionY = 1;
        SoundPlayer player = new SoundPlayer(@"C:\Users\Abdul\source\repos\ConsoleApp1\ConsoleApp1\flabby-burd.wav");
        SoundPlayer win = new SoundPlayer(@"C:\Users\Abdul\source\repos\ConsoleApp1\ConsoleApp1\win.wav");
        Random rand = new Random();

        char[] bag = new char[1];
        char[,] map = {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','D'},
            {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'}, 
            {'#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#',' ','#','#'},
            {'#',' ','#','#','#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
        }; 


        for(int it = 0; it < 15;)
        {
            int pointRand1 = rand.Next(0, map.GetLength(0) - 1);
            int pointRand2 = rand.Next(0, map.GetLength(1) - 1);
            if(map[pointRand1, pointRand2] == ' '&& map[pointRand1, pointRand2] != '@' && map[pointRand1, pointRand2] != '*')
            {
                map[pointRand1,pointRand2] = '*';
                it++;
            }
        }
        

        while (isOpen)
        {
            
            Console.SetCursorPosition(0, 25);
            Console.Write("Сумка: ");
            for (int g = 0; g < bag.Length;g++)
            {
                Console.Write(bag[g] + " ");
            }
            Console.WriteLine("\nОсталось собрать поинтов: " + (16 - bag.Length));
            Console.WriteLine("Всего: " + (bag.Length - 1));
            Console.SetCursorPosition(0,0);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();

            }
            
            
            
            Console.SetCursorPosition(userPositionY, userPositionX);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('@');
            Console.ForegroundColor = std;
            ConsoleKeyInfo charKey = Console.ReadKey();

            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    if (userPositionX > 0 && map[userPositionX - 1, userPositionY] != '#') userPositionX--;
                    break;

                case ConsoleKey.DownArrow:
                    if (userPositionX < map.GetLength(0) - 1 && map[userPositionX + 1, userPositionY] != '#') userPositionX++;
                    break;

                case ConsoleKey.RightArrow:
                    if (userPositionY < map.GetLength(1) - 1 && map[userPositionX, userPositionY + 1] != '#') userPositionY++;
                    break;

                case ConsoleKey.LeftArrow:
                    if (userPositionY > 0 && map[userPositionX, userPositionY - 1] != '#') userPositionY--;
                    break;

                case ConsoleKey.Escape:
                    isOpen = false;
                    break;


            }
            
            
            if (map[userPositionX, userPositionY] == '*')
            {
                map[userPositionX, userPositionY] = ' ';
                player.Play();
                char[] tempBag = new char[bag.Length + 1];

                for(int newSector = 0; newSector < bag.Length; newSector++)
                {
                    tempBag[newSector] = bag[newSector];
                }

                tempBag[tempBag.Length - 1] = '*';
                bag = tempBag;
            }

            if (map[userPositionX,userPositionY] == 'D' && bag.Length == 16)
            {
                isWin = true;
                isOpen = false;
                
            }

            Console.Clear();
            Console.Clear();


        }
        while (isWin)
        {
            win.Play();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Поздравляю вы прошли игру.\nНажмите любую кнопку чтобы выйти");
            Console.ReadKey();
            isWin = false;
            Console.ForegroundColor= std;
        }

    }

    
}
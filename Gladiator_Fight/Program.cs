using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        double playerHealth1 = random.Next(80,111);
        double playerHealth2 = random.Next(70, 91);

        double playerArmour1;
        double playerArmour2;

        int playerDamage1;
        int playerDamage2;

        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.Clear();
        Console.WriteLine("Добро пожаловать в гладиаторские бои!");

        while (true)
        {
            playerArmour1 = random.Next(10, 41);
            playerArmour2 = random.Next(22, 39);

            playerDamage1 = random.Next(20,39);
            playerDamage2 = random.Next(30, 41);

            
            playerHealth1 -= playerDamage2 - ((playerArmour1 / 100) * playerDamage2);
            if (playerHealth1 <= 0) break;
            Console.WriteLine($"Гладиатор 2 нанес урон {playerDamage1 - (playerArmour1 / 100) * playerDamage2} Гладиатору 1.Остаток здоровья Гладиатор 1: {playerHealth1}.");
            playerHealth2 -= playerDamage1 - ((playerArmour2 / 100) * playerDamage1);
            if (playerHealth2 <= 0) break;
            Console.WriteLine($"Гладиатор 1 нанес урон {playerDamage1 - (playerArmour2 / 100) * playerDamage1} Гладиатору 2.Остаток здоровья Гладиатор 2: {playerHealth2}.");

        }

        if(playerHealth1 > 0 || playerHealth2 < 0) Console.WriteLine($"Гладиатор 1 победил!\nОставщееся здоровье: {playerHealth1}.");

        else if (playerHealth1 <= 0 && playerHealth2 >= 0) Console.WriteLine($"Гладиатор 2 победил!\nОставщееся здоровье: {playerHealth2}.");
        
        Console.ReadKey();

    }

    
}
using Namespace;

Hero hero = new Hero();
Monster monster = new Monster();


Console.WriteLine ("Du kommer in i grottan och ska slåss mot monstret");

Console.ReadLine();

Console.WriteLine ("Striden börjar");

Console.ReadLine();

Console.WriteLine($"{hero.name} har {hero.health} health");

Console.WriteLine($"{monster.name} har {monster.healthpoints} health");

Console.ReadLine();

while (monster.healthpoints > 0) 
{
monster.healthpoints -= 20;
Console.WriteLine($"{hero.name} gör {hero.attack} skada!");
Console.WriteLine($"{monster.name} har nu {monster.healthpoints} liv kvar!");
Console.WriteLine("Klicka för att attackera igen!");
Console.ReadLine();
}

if (monster.healthpoints < 1 )
Console.WriteLine("Grattis du besegrade monstret!");
Console.ReadLine();
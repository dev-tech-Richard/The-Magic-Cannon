/* 
 Skorin, a member of Consolas's wall guard, has constructed a magic cannon that draws power from two gemns:
a fire gem and an electric gem. Every third turn of the crank, the fire gem activates, and the cannon produces a fire blast. The electric gem activates every fifth turn of the crank, and the cannon makes an electric blast. When the two line up, it generates a petent combined blast. Skorin would like you rhelp to produce a program that can warn the crew about which turns of the crank will produce the different blast before they do. 
 */








for (int count = 1; count < 100; count++)
{
    if (count % 3 == 0)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Fire");
    }
    if (count % 5 == 0)
    {
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("Electric");
    }
    if (count % 3 == 0 && count % 5 == 0)
    {
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine("Fire and Electric");
    }
    else
        Console.ForegroundColor= ConsoleColor.White;
        Console.WriteLine("normal");

}
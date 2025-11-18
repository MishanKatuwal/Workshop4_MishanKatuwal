class Player
{
    public string playerName;
    public int level;
    public int health;

    // default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // parameterized constructor
    public Player(string name, int lvl, int hp)
    {
        playerName = name;
        level = lvl;
        health = hp;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // using default constructor
        Player p1 = new Player();

        // using parameterized constructor
        Player p2 = new Player("Warrior", 5, 100);

        // printing values (object 1)
        Console.WriteLine(p1.playerName);
        Console.WriteLine(p1.level);
        Console.WriteLine(p1.health);

        // printing values (object 2)
        Console.WriteLine(p2.playerName);
        Console.WriteLine(p2.level);
        Console.WriteLine(p2.health);
    }
}

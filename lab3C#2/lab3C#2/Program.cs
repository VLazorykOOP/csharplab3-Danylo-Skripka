using System;

class Ship
{
    protected string name;
    protected double length;
    protected double width;

    public Ship(string name, double length, double width)
    {
        this.name = name;
        this.length = length;
        this.width = width;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Назва: {name}, Довжина: {length}, Ширина: {width}");
    }
}

class Steamship : Ship
{
    protected double enginePower;

    public Steamship(string name, double length, double width, double enginePower) : base(name, length, width)
    {
        this.enginePower = enginePower;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Потужність двигуна: {enginePower}");
    }
}

class Sailboat : Ship
{
    protected int sailCount;

    public Sailboat(string name, double length, double width, int sailCount) : base(name, length, width)
    {
        this.sailCount = sailCount;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Кількість вітрил: {sailCount}");
    }
}

class Corvette : Ship
{
    protected int gunCount;

    public Corvette(string name, double length, double width, int gunCount) : base(name, length, width)
    {
        this.gunCount = gunCount;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Кількість гармат: {gunCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ship[] fleet = new Ship[4];
        fleet[0] = new Steamship("Титанік", 269, 28, 20000);
        fleet[1] = new Sailboat("Бригантина", 55, 12, 3);
        fleet[2] = new Corvette("Адмірал", 64, 10, 20);
        fleet[3] = new Steamship("Океанія", 320, 32, 25000);

        Console.WriteLine("Список суден:");
        foreach (Ship ship in fleet)
        {
            ship.Show();
            Console.WriteLine();
        }
    }
}

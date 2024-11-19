// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Ucet u1 = new("Pepa");
Ucet u2 = new("Karel", 10000);
Ucet u3 = new("Franta", 20000, 5000);
Ucet u4 = new("Honza")
{
    Zustatek = 5000
};
Ucet u5 = new("Milan")
{
    Zustatek = 5000,
    Kontokorent = 5000
};

Ucet[] ucty = { u1, u2, u3, u4, u5 };
foreach (var u in ucty)
{
    Console.WriteLine(u);
}

u1.Vklad(1000);
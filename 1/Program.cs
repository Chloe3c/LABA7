Football[] fb = new Football[3];
for (int i = 0; i < fb.Length; i++)
{
    Console.Write("Введите фамилию футболиста: ");
    string name = Console.ReadLine();
    Console.Write("Введите амплуа: ");
    string amp = Console.ReadLine();
    Console.Write("Введите возраст: ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Введите количество игр: ");
    int games = int.Parse(Console.ReadLine());
    Console.Write("Введите количество голов: ");
    int goal = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Football fbs = new Football(name, amp, age, games, goal);
    fb[i] = fbs;

}
foreach (Football item in fb)
    if (item.Games < 5) item.Print() ;

int maxGoals = fb[0].Goals;
string topScorerName = fb[0].Name;
Console.WriteLine();

foreach (Football item in fb)
{
    if (item.Goals > maxGoals)
    {
        maxGoals = item.Goals;
        topScorerName = item.Name;
    }
}

Console.WriteLine($"Максимальное количество голов: {maxGoals} (Футболист: {topScorerName})");

struct Football
{
    public string Name;
    public string Am;
    public int Age;
    public int Games;
    public int Goals;
    public Football(string name, string amp, int age, int games, int goal)
    {
        Name = name;
        Am = amp;
        Age = age;
        Games = games;
        Goals = goal;
    }
    public void Print()
    {
        Console.WriteLine($"Фамилия:{Name} Амплуа:{Am} Возраст:{Age} Игр:{Games} Голов:{Goals}");
    }
}
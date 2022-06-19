double srednia;
Console.WriteLine("Podaj srednia ocen:");
srednia = double.Parse(Console.ReadLine());

if (srednia <=3.99)
    Console.WriteLine("Twoje stypendium wynosi: 0pln");
else if (srednia <= 4.79)
    Console.WriteLine("Twoje stypendium wynosi: 350pln");
else if (srednia >=4.80)
    Console.WriteLine("Twoje stypendium wynosi: 550pln");

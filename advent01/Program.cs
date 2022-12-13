using Spectre.Console;

// See https://aka.ms/new-console-template for more information
string[] lines = System.IO.File.ReadAllLines("input/input.txt");

// Display the file contents by using a foreach loop.
Dictionary<string, int> elfCalories = new Dictionary<string, int>();
int elfNumber = 1;
string currentElf = "Elf1";
elfCalories.Add("Elf1", 0);
foreach (string line in lines)
{
    bool isNewLine = (line == "");
    if (isNewLine)
    {
        elfNumber++;
        string newElfString = "Elf" + elfNumber;
        currentElf = newElfString;
        elfCalories.Add(currentElf, 0);
    }
    else
    {
        int storedCalories = elfCalories[currentElf];
        int inputCalories = int.Parse(line);
        elfCalories[currentElf] = storedCalories + inputCalories;
    }
}

// Render bar chart of elf calories
AnsiConsole.Write(new BarChart()
    .Width(60)
    .Label("[green bold underline]Number of calories[/]")
    .CenterLabel()
    .AddItems(elfCalories, (elf) => new BarChartItem(
        elf.Key, elf.Value, Color.Yellow)));

// Part two - get three highest calorie elves
int topThreeTotal = 0;
for (int i = 0; i < 3; i++) 
{
    // Thanks, StackOverflow - https://stackoverflow.com/a/10290858
    // greatest value
    int maxCalories = elfCalories.Values.Max();

    // key of the greatest value
    // 4 is the greatest value, and its key is "a", so "a" is the answer.
    string highestCalorieElf = 
        elfCalories.Aggregate((x, y) => x.Value > y.Value ? x : y).Key; // "a"

    AnsiConsole.MarkupLine(":elf: Elf " + highestCalorieElf + " has " + maxCalories +" calories. :christmas_tree:");
    topThreeTotal += maxCalories;
    elfCalories.Remove(highestCalorieElf);
}

AnsiConsole.MarkupLine("Calorie total of top three elves is :pot_of_food: " + topThreeTotal + " :pot_of_food:");




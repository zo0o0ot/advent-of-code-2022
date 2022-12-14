using Spectre.Console;

// See https://aka.ms/new-console-template for more information

string[] lines = System.IO.File.ReadAllLines("input/input.txt");

int score = 0;
// Display the file contents by using a foreach loop.
foreach (string line in lines)
{
    string[] rps = line.Split(' ');
    string player1 = rps[0];
    string player2 = rps[1];
    int outcome = 0;

    int choice = player2 switch 
    {
        "X" => 1, // Rock
        "Y" => 2, // Paper
        "Z" => 3, // Scissors
    };
    score += choice;

    if (player1 == "A") // Rock
    {
        outcome = player2 switch 
        {
            "X" => 3, // Rock - DRAW
            "Y" => 6, // Paper - WIN
            "Z" => 0, // Scissors - LOSE
        }; 
    } 
    else if (player1 == "B") // Paper
    {
        outcome = player2 switch 
        {
            "X" => 0, // Rock - LOSE
            "Y" => 3, // Paper - DRAW
            "Z" => 6, // Scissors - WIN
        };
    } 
    else if (player1 == "C") //Scissors
    {
        outcome = player2 switch 
        {
            "X" => 6, // Rock - WIN
            "Y" => 0, // Paper - LOSE
            "Z" => 3, // Scissors - DRAW
        };
    }
    score += outcome;
}

AnsiConsole.MarkupLine(":elf:Score = " + score +":elf:");
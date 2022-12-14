using Spectre.Console;

// See https://aka.ms/new-console-template for more information

string[] lines = System.IO.File.ReadAllLines("input/input.txt");

int score = 0;
// Display the file contents by using a foreach loop.
foreach (string line in lines)
{
    string[] rps = line.Split(' ');
    string player1 = rps[0];
    string desiredOutcome = rps[1];
    int outcome = 0;
    string player2 = "Rock";

    

    // Hacky StackOverflow answer: https://stackoverflow.com/a/59890465
    if (player1 == "A") // Rock
    {
        outcome = desiredOutcome switch 
        {
            "X" => ((Func<int>)(() => { //LOSE
                        AnsiConsole.MarkupLine(":elf: Need to LOSE vs ROCK :rock: - Pick Scissors :scissors:");
                        player2 = "Scissors";
                        return 0;
                    }))(), 
            "Y" => ((Func<int>)(() => { //DRAW
                        AnsiConsole.MarkupLine(":elf: Need to DRAW vs ROCK :rock: - Pick Rock :rock:");
                        player2 = "Rock";
                        return 3;
                    }))(), 
            "Z" => ((Func<int>)(() => { //WIN
                        AnsiConsole.MarkupLine(":elf: Need to WIN vs ROCK :rock: - Pick paper :newspaper:");
                        player2 = "Paper";
                        return 6;
                    }))(),
        }; 
    } 
    else if (player1 == "B") // Paper
    {
        outcome = desiredOutcome switch 
        {
            "X" => ((Func<int>)(() => { //LOSE
                        player2 = "Rock";
                        return 0;
                    }))(), 
            "Y" => ((Func<int>)(() => { //DRAW
                        player2 = "Paper";
                        return 3;
                    }))(), 
            "Z" => ((Func<int>)(() => { //WIN
                        player2 = "Scissors";
                        return 6;
                    }))(),
        };
    } 
    else if (player1 == "C") //Scissors
    {
        outcome = desiredOutcome switch 
        {
            "X" => ((Func<int>)(() => { //LOSE
                        player2 = "Paper";
                        return 0;
                    }))(), 
            "Y" => ((Func<int>)(() => { //DRAW
                        player2 = "Scissors";
                        return 3;
                    }))(), 
            "Z" => ((Func<int>)(() => { //WIN
                        player2 = "Rock";
                        return 6;
                    }))(),
        };
    }
    score += outcome;

    int choice = player2 switch 
    {
        "Rock" => 1, // Rock
        "Paper" => 2, // Paper
        "Scissors" => 3, // Scissors
    };
    score += choice;
}

AnsiConsole.MarkupLine(":elf:Score = " + score +":elf:");
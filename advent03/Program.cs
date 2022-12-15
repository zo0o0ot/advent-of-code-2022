using Spectre.Console;
using System.Linq;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information

string[] lines = System.IO.File.ReadAllLines("input/input.txt");
  
int itemSum = 0;
int lineNumber = 1;
// Display the file contents by using a foreach loop.
List<string> group = new List<string>();
foreach (string line in lines)
{
    int groupSize = group.Length;
    if (groupSize < 3 )
    {
        group.Add(line);
    }

    if (group.Length == 3)
    {
        
    }

    //int strlen = line.Length;
    //int half = strlen/2;

    //string firstCompartment = line.Substring(0,half);
    //string secondCompartment = line.Substring(half);

    //var common = firstCompartment.Intersect(secondCompartment);


    //AnsiConsole.MarkupLine("First half: " + line.Substring(0,half));
    //AnsiConsole.MarkupLine("Second half: " + line.Substring(half));

    //foreach (var c in common)
    //{
        AnsiConsole.MarkupLine(":check_mark_button: Line " + lineNumber + " Common character: " + c);
        int charVal = 0;
        charVal = getPoints(c.ToString());
        AnsiConsole.MarkupLine(":chart_increasing: Character value: " + charVal );
        itemSum += (charVal);
    //}


    
    
    AnsiConsole.MarkupLine(":backpack: Item sum : " + itemSum);

    
}

int getPoints(string s)
{
    int points = s switch
    {
        "a" => 1,
        "b" => 2,
        "c" => 3,
        "d" => 4,
        "e" => 5,
        "f" => 6,
        "g" => 7,
        "h" => 8,
        "i" => 9,
        "j" => 10,
        "k" => 11,
        "l" => 12,
        "m" => 13,
        "n" => 14,
        "o" => 15,
        "p" => 16,
        "q" => 17,
        "r" => 18,
        "s" => 19,
        "t" => 20,
        "u" => 21,
        "v" => 22,
        "w" => 23,
        "x" => 24,
        "y" => 25,
        "z" => 26,
        "A" => 26 + 1,
        "B" => 26 + 2,
        "C" => 26 + 3,
        "D" => 26 + 4,
        "E" => 26 + 5,
        "F" => 26 + 6,
        "G" => 26 + 7,
        "H" => 26 + 8,
        "I" => 26 + 9,
        "J" => 26 + 10,
        "K" => 26 + 11,
        "L" => 26 + 12,
        "M" => 26 + 13,
        "N" => 26 + 14,
        "O" => 26 + 15,
        "P" => 26 + 16,
        "Q" => 26 + 17,
        "R" => 26 + 18,
        "S" => 26 + 19,
        "T" => 26 + 20,
        "U" => 26 + 21,
        "V" => 26 + 22,
        "W" => 26 + 23,
        "X" => 26 + 24,
        "Y" => 26 + 25,
        "Z" => 26 + 26,
        _ => 0,
    };
    return points;
}


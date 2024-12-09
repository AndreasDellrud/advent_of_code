// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

// var file = new FileInfo(@"C:\Development\advent_of_code\2024\01\input.txt");
// var reports = File.ReadAllLines(file.FullName);

var exampleInput = @"7 6 4 2 1
1 2 7 8 9
9 7 6 2 1
1 3 2 4 5
8 6 4 4 1
1 3 6 7 9";

var lines = exampleInput.Split(Environment.NewLine);
var reports = new Dictionary<int,int[]>();

foreach (var line in lines)
{
    var key = 1;
    var values = line.Split(' ')
    .Select(x => 
        {
            if(int.TryParse(x.Trim(), out int number))
                return (Success: true, Value: number);
            
            return (Success: false, Value: 0);        
        })
    .Where(result => result.Success)
    .Select(result => result.Value)
    .ToArray();

    reports.Add(key, values);
    key++;
}

ValidateReports(reports);

static void ValidateReports(Dictionary<int, int[]> reports)
{
    var sum = 0;
    foreach(var report in reports)
    {
        //Validate report
        for(var i = 0; i > report.Value.Length; i++)
        {
            
        }

        //Increase sum if valid
        sum++;
    }
}
 
var file = new FileInfo(@"C:\Development\advent_of_code\2024\01\input.txt");
var lines = File.ReadAllLines(file.FullName);

List<int> leftList = [];
List<int> rightList = [];

foreach (var line in lines)
{
    var numbers = line.Split(' ');
    if (int.TryParse(numbers[0].Trim(), out int firstNumber))
        leftList.Add(firstNumber);

    if (int.TryParse(numbers[^1].Trim(), out int secondNumber))
        rightList.Add(secondNumber);
}

leftList.Sort();
rightList.Sort();

//FindTotalDistance(lines);

static void FindTotalDistance(List<int> leftList, List<int> rightList)
{
    var result = leftList.Select((x, index) => Math.Abs(x - rightList[index])).Sum();

    Console.WriteLine(result);
}


//Part 2
SimilarityCounter(leftList, rightList);
static void SimilarityCounter(List<int> leftList, List<int> rightList)
{
    var rightListMapping = rightList.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

    int result = 0;

    foreach(var number in leftList)
    {
        if(rightListMapping.TryGetValue(number, out int count))
            result += number * count;
    }

    Console.WriteLine($"Similarity score: {result}");
}
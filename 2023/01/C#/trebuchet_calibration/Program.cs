// See https://aka.ms/new-console-template for more information

var numberConversions = new Dictionary<string, string>{
    {"one", "1"},
    {"two", "2"},
    {"three", "3"},
    {"four", "4"},
    {"five", "5"},
    {"six", "6"},
    {"seven", "7"},
    {"eight", "8"},
    {"nine", "9"},
};

var calibrationLines = File.ReadAllLines("../calibration_data.txt");

var calibrationData = new List<int>();
foreach (var line in calibrationLines)
{
    List<string> numbers = [];

    foreach(var character in line.Select((value, i) => new {i, value})){
        if(char.IsDigit(character.value))
            numbers.Add(character.value.ToString());
        else{
            foreach(var conversion in numberConversions){
                var length = (line.Length - character.i) > conversion.Key.Length ? conversion.Key.Length : line.Length - character.i;
                var substring = line.Substring(character.i, length);
                if(substring.Contains(conversion.Key)){
                    numbers.Add(conversion.Value);
                }
            }
        }
    }
    _ = int.TryParse(string.Join(string.Empty, numbers.First(), numbers.Last()), out int number);
    calibrationData.Add(number);
}


Console.WriteLine(calibrationData.Sum());


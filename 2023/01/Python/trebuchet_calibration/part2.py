number_conversions = {
    "one": "1",
    "two": "2",
    "three": "3",
    "four": "4",
    "five": "5",
    "six": "6",
    "seven": "7",
    "eight": "8",
    "nine": "9",
}

calibration_data = []

with open("../calibration_data.txt", "r") as file:
    calibration_lines = file.readlines()

for line in calibration_lines:
    number_line = line
    for conversion in number_conversions:
        number_line = number_line.replace(conversion, number_conversions[conversion])
        print(number_line)
    numbers = "".join(filter(str.isdigit, number_line))
    print(numbers)

    number = int(numbers[0] + numbers[-1])
    print(number)
    calibration_data.append(number)

print(sum(calibration_data))    

calibration_data = []

with open("../../calibration_data.txt", "r") as file:
    calibration_lines = file.readlines()

for line in calibration_lines:    
    numbers = "".join(filter(str.isdigit, line))
    print(numbers)

    number = int(numbers[0] + numbers[-1])
    print(number)
    calibration_data.append(number)

print(sum(calibration_data))
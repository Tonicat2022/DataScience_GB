# # task 26
# a = int(input('Please input Number to power: '))
# b = int(input('Please input level of power: '))
# def power(number, powerLevel):
#     sum = 0
#     if powerLevel < 1:
#         return 1
#     sum = number * power(number, powerLevel-1)
#     return sum
# x = power(a,b)
# print(x)

# # task 28
a = int(input('Please input first number to summ: '))
b = int(input('Please input second number to summ: '))
def sumFunction(number1, number2):
    sum = 0
    if number2 < 0:
        return 0
    sum = number1 + sumFunction(1, number2-1)
    return sum
x = sumFunction(a,b)
print(x)

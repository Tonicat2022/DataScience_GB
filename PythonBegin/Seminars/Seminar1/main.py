# task 2

# a = int(input('please enter 3-digit number'))
# while a < 100 or a > 999:
#     print("Entered not 3-digit number")
#     a = int(input('please enter 3-digit number'))


# def sumOfDigit(any):
#     x = int(any / 100)
#     y = int((any / 10) % 10)
#     z = int((any % 100) % 10)
#     sum = x+y+z
#     return sum


# print(f"{sumOfDigit(a)} is sum of digin it {a}")


# task 4

# a = int(input('please enter total quantity of shadoof'))
# while a%6 != 0:
#     print("There no way to find answer")
#     a = int(input('please enter total quantity of shadoof'))
# print(f"{a} -> {int(a/6)} {int(a/6*4)} {int(a/6)}")

# task 6

a = int(input('please enter 6-digit number'))
while a < 100000 or a > 999999:
    print("Entered not 6-digit number")
    a = int(input('please enter 6-digit number'))
    
leftPart = a/1000
rightPart = a % 1000


def sumOfDigit(any):
    x = int(any / 100)
    y = int((any / 10) % 10)
    z = int((any % 100) % 10)
    sum = x+y+z
    return sum

if sumOfDigit(leftPart) == sumOfDigit(rightPart):
    print("You have got Happy ticket!")
else:
    print("No, try again next time")
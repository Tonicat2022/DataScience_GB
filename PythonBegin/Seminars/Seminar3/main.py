# task 16
x =int(input("Please enter size of range"))
r = [i for i in range(1,x+1)]
print(r)
n =int(input("Please enter Number"))
count = 0
for i in range(0,x):
    if r[i] == n:
        count += 1
print(count)

# # task 18
# x =int(input("Please enter size of range"))
# r = [i for i in range(1,x+1)]
# print(r)
# n =int(input("Please enter Number"))

# check = n
# for i in range(0,x):
#     if abs(n-r[i]) < check:
#         find = i
#         check = abs(n-r[i])
# print(r[find])

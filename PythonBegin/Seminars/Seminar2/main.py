# # task 12 v1

# s = int(input('please enter sum of numbers'))
# while s < 0 or s > 2000:
#     print("not allowed sum")
#     s = int(input('please enter sum of numbers'))
# p = int(input('please enter product of two numbers'))
# while p < 0 or p > 1000000:
#     print("not allowed product amount")
#     p = int(input('please enter product of two numbers'))
# result = False
# x = 0
# while (x < 1001 and result != True):
#     y = 0
#     while (y < 1001 and result != True):
#         if x+y == s and x*y == p :
#             result = True
#         else:
#             y += 1
#     x += 1
# if x == 1001 and y == 1001:
#     print(f"There is no dicision")
# else:
#     print(f"x = {x-1} and y = {y}")

# # task 12 v2

# s = int(input('please enter sum of numbers'))
# while s < 0 or s > 2000:
#     print("not allowed sum")
#     s = int(input('please enter sum of numbers'))
# p = int(input('please enter product of two numbers'))
# while p < 0 or p > 1000000:
#     print("not allowed product amount")
#     p = int(input('please enter product of two numbers'))

# result = False
# for x in range(0,1001):
#     for y in range(0,1001):
#         if x+y == s and x*y == p :
#             result = True
#             break
#     if result:
#         break
# if result:
#     print(f"x = {x} and y = {y}")
# else:
#     print(f"There is no dicision")

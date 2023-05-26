data = [1,2,3,5,8,12,15,23,38]
res = map(int, data)
res = filter(lambda x: x%2 == 0, res)
# print(res)
res = list(map(lambda x: (x, x**2, x**3), res))
print(res)
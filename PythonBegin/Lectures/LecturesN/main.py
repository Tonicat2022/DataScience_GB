# def f(x):
#     return x ** 2
# g = f
# print(f(5))
# print(g(5))
## lambda
# def math(op, x, y):
#     print(op(x, y))

# math(lambda a, b: a+b, 5, 4)
# math(lambda a, b: a*b, 5, 4)

data = [1,2,3,5,8,12,15,23,38]
# res = list()

# for i in data:
#     if i%2 == 0:
#         res.append((i, i**2))

# print(res)
def select(f, col):
    return [f(x) for x in col]

def where(f, col):
    return [x for x in col if f(x)]

res = select(int, data)
print(res)
res = where(lambda x: x%2 == 0, res)
print(res)
res = select(lambda x: (x, x**2), res)
print(res)
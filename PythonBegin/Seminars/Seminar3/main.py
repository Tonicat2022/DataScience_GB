# # task 16
# x =int(input("Please enter size of range"))
# r = [i for i in range(1,x+1)]
# print(r)
# n =int(input("Please enter Number"))
# count = 0
# for i in range(0,x):
#     if r[i] == n:
#         count += 1
# print(count)

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

# task 20
word =str(input("Please enter any word: "))
upper = word.upper()
one = ('A','E','I','O','U','L','N','S','T','R','А','В','Е','И','Н','О','Р','С','Т')
two = ('D','G','Д','К','Л','М','П','У')
three = ('B','C','M','P','Б','Г','Ё','Ь','Я')
four = ('F','H','V','W','Y','Й','Ы')
five = ('K','Ж','З','Х','Ц','Ч')
eight = ('J','X','Ш','Э','Ю')
ten = ('Q','Z','Ф','Щ','Ъ')
scors = {}
scors.update({ (i,1) for i in one})
scors.update({ (i,2) for i in two})
scors.update({ (i,3) for i in three})
scors.update({ (i,4) for i in four})
scors.update({ (i,5) for i in five})
scors.update({ (i,8) for i in eight})
scors.update({ (i,10) for i in ten})
# print(scors)
# print(upper, len(upper))
sum = 0
for i in range(0,len(upper)):
    print(f"{word[i]} > {scors[upper[i]]}")
    sum += scors[upper[i]]
print(sum)
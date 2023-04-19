# # task 22
# import random
# n = int(input('please input quantity of elements in first array: '))
# m = int(input('please input quantity of elements in second array: '))
# nArray = set()
# mArray = set()

# while len(nArray) <n:
#   nArray.add(int(input(f"please enter {len(nArray)+1} element of first array: ")))
# while len(mArray) <m:
#   mArray.add(int(input(f"please enter {len(mArray)+1} element of second array: ")))

# outcomeArray = nArray.intersection(mArray)

# print(nArray)
# print(mArray)
# print(outcomeArray)

# task 24
import random
n = int(input('please input quantity of bushs: '))
b = n+1
while b > n:
  b = int(input(f'please input which bush you want to start, it should be lower or equal to {n}: '))
# bush ={ (i+1, random.randint(1,1000)) for i in range(0,n) }
bushProductivity = [random.randint(1,1000) for i in range(0,n) ]
print(bushProductivity)
print(f"start collection from {b} bush")
if b == 1: left = bushProductivity[n-1]
else: left = bushProductivity[b-2]
if b == n: right = bushProductivity[0]
else: right = bushProductivity[b]
max = left + bushProductivity[b-1] + right
print(f"Max productivity will be: {left} + {bushProductivity[b-1]} + {right} = {max}")

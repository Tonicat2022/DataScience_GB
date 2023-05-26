def create_list_progression(a1, d, n):
    lst = []
    for i in range(n):
        lst.append(a1 + i * d)
    return lst

def create_list(a1, d, n):
    return [a1 + i *d for i in range(n)]

a1 = int(input("Enter first element of the progression"))
n = int(input("Enter quantity of elements in the progression"))
d = int(input("Enter step of the progression"))

print("Progression is: ")
print(create_list(a1, d, n))
print("")
print("Progression is: ")
print(create_list_progression(a1, d, n))

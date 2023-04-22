# import module1 as m1
# print(m1.max1(5,2))

# # Fibonachi
# def fib(n):
#     if n in [1,2]:
#         return 1
#     return fib(n-1)+fib(n-2)
# list_1 = []
# maxElement = int(input('please enter max element of array in Fibonachi: '))
# for i in range(1, maxElement):
#     list_1.append(fib(i))
# print(list_1)

# # Quick_sort
# def quick_sort(array):
#     if len(array) <= 1:
#         return array
#     else:
#         pivot = array[0]
#     less = [i for i in array[1:] if i <= pivot]
#     greater = [i for i in array[1:] if i > pivot]
#     return quick_sort(less) + [pivot] + quick_sort(greater)
# print(quick_sort([10,5,2]))

# Merge_sort
def merge_sort(nums):
    if len(nums) > 1:
        mid = len(nums) // 2
        left = nums[:mid]
        right  = nums[mid:]
        merge_sort(left)
        merge_sort(right)
        i = j = k = 0
        while i < len(left) and j < len(right):
            if left[i] < right[j]:
                nums[k] = left[i]
                i += 1
            else:
                nums[k] = right[j]
                j += 1
            k += 1

        while i < len(left):
            nums[k] = left[i]
            i += 1
            k += 1

        while j < len(right):
            nums[k] = right[j]
            j += 1
            k += 1
list1 = [1,5,6,9,8,7,2,1,55,2,4]
list1 = merge_sort(list1)
print(list1)
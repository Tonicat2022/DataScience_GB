# ##task 34
# def check_rhythm(speech):
#     lines = speech.split()
#     # print(lines)
#     slogov = []
#     for line in lines:
#         words = line.split('-')
#         # print(words)
#         slog = sum(word.count(glasnih) for word in words for glasnih in 'ауоыиэяюёеАУОЫИЭЯЮЁЕ')
#         # print(slog)
#         slogov.append(slog)
#     # print(slogov)
#     # print(set(slogov))
#     # print(len(set(slogov)))

#     if len(set(slogov)) == 1: #проверка уникальности количеcтва гласных, должно быть уникальным, т.е. равно 1
#         return "Парам пам-пам"
#     else:
#         return "Пам парам"

# speech1 = "пара-ра-рам рам-пам-папам па-ра-па-да"
# speech2 = "папам-парам рапам-рапам"
# speech3 = speech1+speech2
# # speech = input("Введите стихотворение Винни-Пуха: ")
# print(f"ввод: {speech1} вывод -> {check_rhythm(speech1)}")
# print(f"ввод: {speech2} вывод -> {check_rhythm(speech2)}")
# print(f"ввод: {speech3} вывод -> {check_rhythm(speech3)}")

##task 36
def print_table (operation, rows = 6, columns = 6):
    for i in range(1, rows+1):
        for j in range(1, columns+1):
            print(operation(i, j), end="\t")
        print()

def print_table2 (operation, rows = 6, columns = 6):
    [print(operation(i, j), end="\t") for i in range(1,rows+1) for j in range(1,columns+1)]

def print_operation_table(operation, num_rows=6, num_columns=6):
    table = [[operation(row, column) for column in range(1, num_columns + 1)] for row in range(1, num_rows + 1)]
    for row in table:
        print(*row)


print_table(lambda x, y: x*y)
print_table2(lambda x, y: x*y)
print_operation_table(lambda x, y: x * y)
def check_rhythm(speech):
    lines = speech.split()
    # print(lines)
    slogov = []
    for line in lines:
        words = line.split('-')
        # print(words)
        slog = sum(word.count(glasnih) for word in words for glasnih in 'ауоыиэяюёеАУОЫИЭЯЮЁЕ')
        # print(slog)
        slogov.append(slog)
    # print(slogov)
    # print(set(slogov))
    # print(len(set(slogov)))


    if len(set(slogov)) == 1: #проверка уникальности количетва гласных, должно быть уникальным, т.е. равно 1
        return "Парам пам-пам"
    else:
        return "Пам парам"

speech1 = "пара-ра-рам рам-пам-папам па-ра-па-да"
speech2 = "папам-парам рапам-рапам"
speech3 = speech1+speech2
# speech = input("Введите стихотворение Винни-Пуха: ")
print(f"ввод: {speech1} вывод -> {check_rhythm(speech1)}")
print(f"ввод: {speech2} вывод -> {check_rhythm(speech2)}")
print(f"ввод: {speech3} вывод -> {check_rhythm(speech3)}")


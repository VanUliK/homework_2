# Орел и решка

# Дана строка текста, состоящая из букв русского алфавита "О" и "Р". Буква "О" – соответствует выпадению Орла, а буква "Р" – соответствует выпадению Решки. Напишите программу, которая подсчитывает наибольшее количество подряд выпавших Решек.

# Формат входных данных
# На вход программе подается строка текста, состоящая из букв русского алфавита "О" и "Р".

# Формат выходных данных
# Программа должна вывести наибольшее количество подряд выпавших Решек.

# Примечание. Если выпавших Решек нет, то необходимо вывести число
# 0
# 0.

# Тестовые данные 🟢
# Sample Input 1:
# ОРРОРОРООРРРО
# Sample Output 1:
# 3
# Sample Input 2:
# ООООООРРРОРОРРРРРРР
# Sample Output 2:
# 7
# Sample Input 3:
# ООООРРРРОРОРРРРРРРРООРОРОРРРРРРРРРРРРРРРРРРРРРРРРРРРРРРР
# Sample Output 3:
# 31

# orel_reshka = input()
# r = 0
# reshka_max = 0
# for i in orel_reshka:
#     if (i == "Р"):
#         r += 1
#     elif (r > reshka_max):
#         reshka_max = r
#         r = 0
#     else:
#         r = 0


# print(reshka_max)

s = input()
t = 0
while "Р"*(t+1) in s:
    t += 1
if t != 0:
    print(t)
else:
    print(0)

# Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
chislo=int(input("Input number - "))
stroka=[int(i) for i in (input("Input list - ").split())]
stroka2 = [x for x in stroka if chislo==x]
print(len(stroka2))
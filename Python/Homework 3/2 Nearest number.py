# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X
import random
stroka=[random.randint(1,100) for i in range(random.randint(10,15))]
print(f'У нас есть такой массив {stroka}')
chislo=int(input("Какое число будем искать - "))
for i in range(len(stroka)-1): stroka.pop(abs(stroka[0]-chislo)<abs(stroka[1]-chislo))
print(f'Ближайшее к вашему числу - {stroka[0]}')
import random
stroka1=[random.randint(1,20) for i in range(random.randint(10,15))]
stroka2=[random.randint(1,20) for i in range(random.randint(10,15))]
print(f'У нас есть такой массив A - {stroka1}, и массив В - {stroka2}')
res = set(stroka1).intersection(set(stroka2))
print(f'Результат - {res}')

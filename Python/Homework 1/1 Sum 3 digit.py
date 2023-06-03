import random
rnd = random.randint(100,999)           # Загадаем случайное трехзначное число
sum = rnd//100 + rnd%100//10+ rnd%10
print (rnd,' -> ',sum)
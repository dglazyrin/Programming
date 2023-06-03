import random
rnd = random.randint(100000,999999)           # Загадаем случайное трехзначное число
print (rnd,' -> ',rnd//100000 + rnd%100000//10000+rnd%10000//1000 == rnd%1000//100 + rnd%100//10+ rnd%10)
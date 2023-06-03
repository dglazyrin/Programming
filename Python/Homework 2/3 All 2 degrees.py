import random
rnd = random.randint(1,999999)           # Загадаем случайное число
i=0
while 2**i < rnd:
     print (2**i)
     i+=1
print ("Это все степени двойки, меньше загаданного числа",rnd)
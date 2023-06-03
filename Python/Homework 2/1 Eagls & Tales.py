import random
coins = random.randint(1,99)           # Загадаем случайное число монет
eagles = random.randint(1,coins-1)           # Загадаем случайное число орлов
tales=coins-eagles
print("На столе",coins,"монет.",end=" ")
if tales==eagles:
     print("Переворачивай любые, их поровну.")
else:
     if tales>eagles:
          print("Переворачивай орлов, их всего-то",eagles,"Не то, что решек, их",tales)
     else: print("Переворачивай решки, их всего-то",tales,"Не то, что орлов, их",eagles)
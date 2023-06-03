import random
lenght = random.randint(2,30)           # Загадаем длину шоколадки
width = random.randint(2,30)           # Загадаем ширину шоколадки
piece = random.randint(2,15)           # Загадаем площадь кусочка
print (lenght,width,piece,' -> ',(piece%lenght==0 or piece%width==0) and piece<=lenght*width)
# Условие - длина или ширина кратны размеру отламываемого кусочка и кусочек меньше площади шоколадки
import random                             # Очевидно что количество птичек будет кратно 6
rnd = random.randrange(6,996,6)           # Загадаем случайное трехзначное число
boy = rnd//6
print (rnd, ' -> ',boy,boy*4,boy)
def stepen(x,y):
     if y==0 or x<2:
          return 1
     return stepen(x,y-1)*x
     
import random
num_1 = random.randint(0,10)
num_2 = random.randint(0,10)
print(f'Возведём {num_1} в степень {num_2} => {stepen(num_1,num_2)}')
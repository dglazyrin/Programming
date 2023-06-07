def to_bin(x,y=1):
     if x==0:
          return 0
     else:
          return (x%2)*y+to_bin(x//2,y*10)

import random
my_number = random.randint(0,100)
print (my_number," =>", to_bin(my_number))
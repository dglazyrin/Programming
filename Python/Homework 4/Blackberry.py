import random
gryadka=[random.randint(100,300) for i in range(random.randint(4,7))]
print(f'У нас есть такая грядка - {gryadka}')
newlist = [(gryadka[i-2]+gryadka[i-1]+gryadka[i]) for i in range(len(gryadka))]
newlist.insert(len(newlist),newlist[0])
newlist.pop(0)
print(newlist)
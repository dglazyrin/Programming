import random
my_mass=[random.randint(-100,100) for i in range(random.randint(15,25))]
my_min = random.randint(-50,0)
my_max = random.randint(1,100)
#p_vol = random.randint(2,20)
print(f'У нас есть такой массив {my_mass}')
print(f'Диапазон поиска - [{my_min},{my_max}]')
my_mass2 = [i for i in range(len(my_mass)) if (my_mass[i]>=my_min and my_mass[i]<=my_max)]
print(my_mass2)
import random
p_start = random.randint(0,10)
p_step = random.randint(1,10)
p_vol = random.randint(2,20)
print('Начало прогрессии -',p_start)
print('Шаг прогрессии -',p_step)
print('Число членов - ',p_vol)
my_progr = [p_start+p_step*i for i in range(p_vol)]
print (my_progr)
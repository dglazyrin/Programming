import random
mass=[]
mass3=[]
mylist=('A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','V','W','X','Y','Z','a','b','c','d','e',
        'f','g','h','i','j','k','l','m','n','o','p','q','r','t','s','v','w','x','y','z','1','2','3','4','5','6','7','8','9','0')
kol = random.randint(15,30)     # Зададим количество массивов для сортировки
for i in range(kol):            # Заполним массивы случайными данными произвольной длинны
     slovo=''
     for lenght in range(random.randint(1,8)):
          slovo=slovo+random.choice(mylist)
     mass.insert(i,slovo)       # Создадим список получившихся массивов
     if len(slovo)<4:           # И сразу создадим второй список из массивов,
          mass3.insert(0,slovo) # удовлетворяющих условию задачи.
print(f'У нас получилось {kol} массивов:')
print(', '.join(mass))
print('Уберем из них те, что длиннее 3')
print(', '.join(mass3))
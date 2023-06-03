slovar=['AEIOULNSTRАВЕИНОРСТ0','DGДКЛМПУ1','BCMPБГЁЬЯ2','FHVWYЙЫ3','KЖЗХЦЧ4','JXШЭЮ7','QZФЩЪ9']
slovo=str(input("Введите слово - ").upper())
price=int(0)
for i in slovo:
     for j in slovar:
          if i in j:
               price+=int(j[-1])+1
print(price)
import random

D = {}
maxKey = 0
maxCount = 0

f = open("numbers.txt",'w')
for i in range(1000):
    key = random.randint(1,100)
    
    f.write(str(key)+'\n')
    
    count = D.get(key,None)
    if count == None:
        D[key] = 1
        #print(key, 'D[key] = 1')
    else:
        D[key] += 1
        #print(key, 'D[key] = ',D[key])

    if D[key] > maxCount:
        maxCount = D[key]
        maxKey = key

f.close()

print("Mode:",maxKey," With",maxCount,"occurrences.")



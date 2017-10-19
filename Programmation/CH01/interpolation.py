""" interpolation.py
    demonstrates variable interpolation
    """

name = input("Hi, what's your name? ")

prompt = "How old are you, %s? " % name

age = input(prompt)
age = int(age)

decades = age / 10.0
print (decades)

print ("%s is %d years old." % (name, age))
print ("That is %.2f decades." % decades)


prompt = "What is the thing you love the most, %s?" %name

love = input(prompt)

print ("So, your name is %s, you're %d years old and you love %s" % (name, age, love))

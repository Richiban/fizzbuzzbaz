
def playNumber(x, rules):
    matches = [rules[y] for y in rules if x % y == 0]
    
    return "".join(matches) or x


def numberGame(start, end, rules):
    return [playNumber(x, rules) for x in range(start, end + 1)]


def fizzbuzz(start, end):
    return numberGame(start, end, {3: "Fizz", 5: "Buzz", 7: "Baz"})


for x in fizzbuzz(1, 100):
    print(x)

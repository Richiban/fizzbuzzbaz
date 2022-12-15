function* numberGame(
  start: number,
  end: number,
  rules: { [key: number]: string }
): Generator<string> {
  for (let i = start; i <= end; i++) {
    let result = "";

    for (const divisor in rules) {
      if (i % Number(divisor) === 0) {
        result += rules[divisor];
      }
    }

    if (result === "") {
      result = String(i);
    }

    yield result;
  }
}

function fizzbuzz(start: number, end: number): Generator<string> {
  return numberGame(start, end, { 3: "Fizz", 5: "Buzz", 7: "Baz" });
}

for (const x of fizzbuzz(1, 100)) {
  console.log(x);
}

class NumberGame(val rules: Map<Int, String>) {
    operator fun invoke(number: Int): String {
        val result = rules
            .filterKeys { divisor -> number % divisor == 0 }
            .toList()
            .joinToString("") { it.second }

        return if (result.isEmpty()) number.toString() else result
    }
}

val fizzbuzz = NumberGame(
    mapOf(
        3 to "Fizz",
        5 to "Buzz",
        7 to "Baz",
    )
)

fun main() {
    for (i in 1..100) {
        println(fizzbuzz(i))
    }
}

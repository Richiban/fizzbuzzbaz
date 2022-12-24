class NumberGame(vararg val rules: Pair<Int, String>) {
    fun playNumber(number: Int): String {
        val result = rules
            .mapNotNull { (divisor, word) -> if (number % divisor == 0) word else null }
            .joinToString("") { it }

        return if (result.isEmpty()) number.toString() else result
    }
    
    operator fun invoke(range: IntRange): List<String> = 
        range.map(::playNumber)
}

val fizzbuzz = NumberGame(
    3 to "Fizz",
    5 to "Buzz",
    7 to "Baz",
)

fun main() {
    for (x in fizzbuzz(1..100)) {
        println(x)
    }
}

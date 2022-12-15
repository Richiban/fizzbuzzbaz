playNumber :: [(Int, String)] -> Int -> String
playNumber rules n =
    let
        playRule (divisor, word) =
            if n `mod` divisor == 0
                then word
                else ""
    in
        case foldl (++) "" $ map playRule rules of
            "" -> show n
            s -> s

fizzbuzz :: [Int] -> [String]
fizzbuzz = map (playNumber [(3, "fizz"), (5, "buzz"), (7, "baz")])

main :: IO()
main = mapM_ putStrLn $ fizzbuzz [1..100]



let playNumber rules number = 
    rules
    |> List.choose (fun (divisor, word) -> 
        if number % divisor = 0 then Some word else None)
    |> function 
        | [] -> string number
        | words -> String.concat "" words

let numberGame rules = Seq.map (playNumber rules)

let fizzbuzz = numberGame [ 3, "Fizz"; 5, "Buzz"; 7, "Baz" ]

fizzbuzz {1..100} |> Seq.iter (printfn "%s")


// function (a: (b: c))
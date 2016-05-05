

let fibonacciSequence = 
    Seq.unfold(fun (current, next) -> Some(next, (next, current + next)))(0, 1) 

[<EntryPoint>]
let main argv = 
    let result = 
        fibonacciSequence 
        |> Seq.takeWhile(fun x -> x < 4000000)
        |> Seq.filter(fun x -> x % 2 = 0)
        |> Seq.sum
    printfn "%i" result
    0 // return an integer exit code

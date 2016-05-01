

let isMultiple divisor number =
    number % divisor = 0


let isMultipleOfDivisors divisors number = 
    List.exists (fun elem -> isMultiple elem number) divisors


let sumMultiples divisors exclusiveUpperBound =
    let upperBound = exclusiveUpperBound - 1
    [2..upperBound]
        |> List.filter (fun x -> isMultipleOfDivisors divisors x)
        |> List.sum
    


[<EntryPoint>]
let main argv = 
    let result = sumMultiples [3; 5;] 1000
    System.Console.WriteLine(result)
    System.Console.ReadLine()
    0 // return an integer exit code






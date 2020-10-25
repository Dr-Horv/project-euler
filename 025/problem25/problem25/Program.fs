open System
open System.Numerics

let rec count_digits i =
    if BigInteger.Compare(i, 10I) < 0
    then 1
    else 1 + count_digits (BigInteger.Divide(i, 10I))

let rec fib_solve a b i =
    let c = BigInteger.Add(a, b)
    if (count_digits c) = 1000 then i else fib_solve b c (i + 1)

[<EntryPoint>]
let main argv =
    let stopWatch = System.Diagnostics.Stopwatch.StartNew()
    printfn "%i" (fib_solve 1I 1I 3)
    stopWatch.Stop()
    printfn "%fms" stopWatch.Elapsed.TotalMilliseconds
    0 // return an integer exit code

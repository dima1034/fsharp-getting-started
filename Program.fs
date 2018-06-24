// Learn more about F# at http://fsharp.org

open System
open Test.Introduction
open Test
open FSharp.Charting



[<EntryPoint>]
let main argv =


    [ for x in 1.0 .. 2.0 -> (x, linear x) ] 
    |> Seq.iter ( fun x -> printf "%A " x ) 
    |> ignore



    [1;2;3;4;] 
        |> List.filter(fun i -> i % 2 = 0)
        |> List.map ((*)2)
        |> List.sum //get_Zero()?
        |> printf "list pattern matching: %A \n"


    let minus1 x = x - 1 // a' -> b'
    let times2 x = x * 2 // b' -> c' 

    // >> a' -> b' & b' -> c' = a' -> c'
    // times2 (minus1 9)
    // << b' -> c' & a' -> b' = a' -> c'
    // minus1 (times2 9)

    // function composition
    let minus1ThenTimes2 = times2 << minus1 << minus1 <| 6 |> printf "minus1ThenTimes2 = %A \n"
    
    let Times2ThenMinus1 = 
        times2 >> minus1 <| 6 |> printf "Times2ThenMinus1 = %A \n"

    // pipes
    12 |> min <| 7 |> printf "12 |> min <| 7 = %A \n"

    let distance = 10 |><| 20 |> printf "10 |><| 20 = %d \n" 
    
    (quicksort [ 1; 2; 3; 4; 5; 6; 100; 7; 8]) |> printf "%A"
    printfn "\n Hello World from F#!"
    0 // return an integer exit code
    
    

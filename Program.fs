// Learn more about F# at http://fsharp.org

open System
open Test.Introduction
open Test

[<EntryPoint>]
let main argv =
    (quicksort [ 1; 2; 3; 4; 5; 6; 100; 7; 8]) |> printf "%A"
    printfn "Hello World from F#!"
    0 // return an integer exit code
    
    

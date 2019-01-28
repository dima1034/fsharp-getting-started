module CSharpInterop

open System
open CSharpLibrary

type Consumer() =
    let c1 = new Numbers()
    member this.number = c1.Getnumber()
    
    interface ICanAddNumber with
        member this.Add (a, b) = a + b


// F# gives posibility to implement inerfaces without creating an class itself
let objectWithAddMethod = { new ICanAddNumber
            with member this.Add (a,b) = a + b }
            
let parseDouble = fun () -> Double.TryParse("3.14159") |> function
        | (true, value) -> printfn "%A" value
        | (false, _) -> printfn "some error occure"

let parseDouble2() = Double.TryParse("3.14159") |> function
        | (true, value) -> printfn "%A" value
        | (false, _) -> printfn "some error occure"
        
        
let patternMatchFunc result = match result with
        | (true, value) -> printfn "%A" value
        | (false, _) -> printfn "some error occure"
                
let patMatFuncCall() = Double.TryParse("55.5") |> patternMatchFunc
        
Double.TryParse("3.14159") |> (fun result ->
        match result with
                | (true, value) -> printfn "%A" value
                | (false, _) -> printfn "some error occure")
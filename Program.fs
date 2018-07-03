// Learn more about F# at http://fsharp.org

open System
open Test.Introduction
open Test
open FSharp.Charting
open FParsec 
open System.IO


type Point = { x: float; y: float } 

type Person = {
    name: string;
    age: int
} with member this.canDrive = this.age > 17

type Day = 
    | Monday 
    | Sunday 
    | Tuesday 
    | Wednesday
    | Friday
    | Saturday
    
type Workday = Rest | PersonPerDay of Day * Person
  
type namedValue<'T> = { name: string; value: 'T }   

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
    
    
    
    //data types
    
    printfn "\n Hello World from F#!"
    printfn "%s" """\n Hello World from F#!""".[3..6]    
    printfn "%s" "Hello World from F#!".[3..6]    
    printfn "%s" "Hello World from F#!".[3..]    
    printfn "%s" "Hello World from F#!".[..6]    
    printfn @"\n Hello ""World"" from \t\tF#!"
    
    // init - result string of applying function on each index
    String.init 10 (fun i -> i * 10 |> string |> (+) " WPR-") |> printf "%A" 
    
    String.forall System.Char.IsDigit "11232a" |> printf "\n %A" 
    
    [for x in 1..10 do yield 2 * x] |> printf "\n %A" 
    [for x in 1..10 -> 2 * x] |> printf "\n %A" 
    
    [
        for r in 1..9 do
        for c in 1..9 do    
            if r <> c then 
                yield (r,c)
    ] |> printf "\n %A"
    
      
    // records 
    { name = "Bob"; age = 55 }.canDrive |> printf "\n can drive = %A"
    
        
    let pl = 
    //          1.2            ,              3.2
        pipe3 pfloat (pchar ',' .>>. spaces) pfloat (fun x z y -> 
            printf "\n %A - z" z
            { x = x; y = y }) 
    
    run pl "1.2, 3.2, 1.2" |> printf "\n%A"
    
    let pl2 = 
        sepBy pfloat (pchar ',' >>. spaces) 
        
    run pl2 "1.2, 3.2, 1.2" |> printf "\n%A"
    
    
    // descriminated unions
    let friday = Day.Friday
    
    (run ((stringReturn "5") "hello world") "5hello    55") |> printf "\n%A"
    
    let getDayNumber (day: Day) = 
        match day with
        |   Day.Friday -> printfn "\n friday" 
        |   _ -> printfn "\n any other day"
    
    getDayNumber Day.Friday
    
    // equality 
    // primitives, list, arrays, tupels, records and DU have structural equality
    // object equality use referntial equality
    
    let s = new System.Exception()
    
    let ss = s :? System.DivideByZeroException
    
    let ss2 = s :? Exception
    
    
    let s2 s =
        printf "%A" s
    
    let readAFile ()= 
        use reader = new StreamReader(
                        __SOURCE_DIRECTORY__ + "\\text.txt")
        reader.ReadToEnd()
        
    readAFile() |> printf "%A" 
//    let result: byref<float> = byref<float>()
    
    let ( isOk, value ) = Double.TryParse("123")  
    
    
    let firstOdd cs = 
        List.tryPick (fun x -> Some x) cs
        
    firstOdd [2;3;5;7] |> printf "%A"
    
    let toNumber opt: option<'a> = 
        let s: option<'a> = Option.bind (fun x -> Some x) opt
        let s2: option<'a> = Option.bind (fun x -> None) s 
        let s3: option<'a> = Option.bind (fun x -> None) s2  
        Option.bind (fun x -> None) s3
        
    Some 5 
    |> toNumber
    |> function 
        | Some v -> v
        | None -> 0
    |> printf "\n%A" 
    |> Console.WriteLine 
    
    
    
    
    
    // requireQualifiedAccess attribute
    // this modules cannot be open.
    // Function in module may be accessed only directly List.<FunctionName>
    
    0 // return an integer exit code
    
   

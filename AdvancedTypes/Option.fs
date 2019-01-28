
module AdvancedTypes.MyOption 
open System

let binder = (fun i -> 
        //desctruct 
    let (succeeded, value) = Double.TryParse(i)
    
    if succeeded then Some value 
    else None)
    
let twoNumbersAndSquare2 option = 
    Option.bind binder option |> Option.bind( fun n -> n * n |> Some )

// same representation      

let twoNumbersAndSquare optn = 
    Option.bind(
    (*binder:*) (fun i -> 
       //desctruct 
       let (succeeded, value) = Double.TryParse(i)
       
       if succeeded then Some value 
       else None)) 
   (*(option:*) optn
    |> Option.bind (fun n -> n * n |> Some)
    |> Option.bind (fun n -> if (n / 100.) = 1. then Some n else None)
    
    // bind only applies if it is actually has value (means if Some came up on input)
    // if option is None bind does not executes
    
    
let print o = 
    match o with 
        | Some v -> sprintf "\n%A" v
        | None -> "\nNOTHING"
        
        
let evaluate s = Some s |> twoNumbersAndSquare |> print |> Console.WriteLine

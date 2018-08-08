module MyOption
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
    
    // bind only applies if it is actually has value (means if Some came up on input)
    // if option is None bind does not executes
    
    
let print o = 
    match o with 
        | Some v -> sprintf "%A" v
        | None -> "None"
        
        
let evaluate s = Some s |> twoNumbersAndSquare |> print |> Console.WriteLine

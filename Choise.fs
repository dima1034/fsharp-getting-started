module MyChoise

let div num den = 
    num / den
    
let safeDiv num den = 
    try Choice2Of2 (num / den) 
    with 
        | :? System.Exception as ex -> Choice1Of2 ex
        
let evaluateMyChoice a b = safeDiv a b 

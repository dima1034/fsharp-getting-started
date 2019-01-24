module MyChoise

let div num den = 
    num / den
//    
//let safeDiv num den = 
//    try Some (num / den) 
//    with 
//        | :? System.DivideByZeroException as dbz -> printfn "%A" (Choice2Of2 dbz); Some dbz
//        | :? System.Exception as ex -> printfn "%A" (Choice1Of2 ex); None
//        
//        // :? Тип исключения	Соответствует указанному типу исключения .NET.
//        
//let evaluateMyChoice a b = safeDiv a b 

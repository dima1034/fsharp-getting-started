module AdvancedTypes.MyChoise

let div num den = 
    num / den
    
let safeDiv (num: float) (den: float) = 
    try
        printfn "%A" (num / den)
        Choice1Of3(num / den) 
    with 
        | :? System.DivideByZeroException as dbz -> printfn "%A" dbz.Message; Choice2Of3(dbz)
        | :? System.Exception             as ex -> printfn "%A" ex.Message; Choice3Of3(ex)
        
        // :? Тип исключения	Соответствует указанному типу исключения .NET.
        
let evaluateMyChoice a b = safeDiv a b 

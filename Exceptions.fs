module Exceptions

exception CountingCustomException of string
exception CountingAnotherCustomException

let someFunctionWhichFails =
    try
        raise (CountingCustomException("just custom exception"))
    with
    | CountingCustomException(msg) -> printfn "%s" msg
    
let someFunctionWhichFails2 =
    try
        raise (CountingAnotherCustomException)
    with
    | CountingAnotherCustomException -> printfn "this just exception without information"
    
//    How to assisgn to identifier?
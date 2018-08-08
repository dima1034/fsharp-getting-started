module ArrListSeq

let arr = [| for x in 1..100 -> x * x|]
let lst = [ for x in 1..100 -> x * x]
let odds = 
    let rec loop x = // Использует рекурсивную локальную функцию
        seq { yield x
              yield! loop (x + 2) }
    loop 1

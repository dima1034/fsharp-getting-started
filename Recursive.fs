module Rec 

let odds = 
    let rec loop x = // Использует рекурсивную локальную функцию
        seq { yield x
              yield! loop (x + 2) }
    loop 1
    
let s = seq { 0 .. 10 .. 100 } |> printf "%A"
do s
module TestModule

printfn "Introduction module"

let rec quicksort = function 
    | [] -> []
    | x :: xs ->
        let smaller = List.filter ((>) x) xs
        let larger = List.filter ((<=) x) xs
        quicksort smaller @ [x] @ quicksort larger
        
        
        
let square x = x * x //compiler will identify types by himself

type twoNumbers = int * int
let add (fst, scnd) = 
    fst + scnd
    
let add_2 fst scnd = 
    fst + scnd
    
let linear x = 2. * x

let quadratic x = x ** 2.

let (|><|) x y = x - y |> abs   


// pattern matching function 
let rec lenght = function 
    | []        -> 0
    | (x :: xs) -> 1 + lenght xs // x - first element in list

// :: (union case list) - means (Head: 'T) * (Tail: 'T list) -> a' list 
// elements
// (Tail: 'T list)
// (Head: 'T)
// a' list 

// [] empty list
// x :: xs or non empty list


[1;2;3;4;] 
    |> List.filter(fun i -> i % 2 = 0)
    |> List.map ((*)2)
    |> List.sum
    |> printf "%A"
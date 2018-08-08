module DU

// type defined a set of choises 
// DU = is sum of it is cases
// DU — это типы, представляющие некоторое количество именованных вариантов.
// На языке теории категорий это называется типом-суммой. 

// "SUM" types 

type MeasurementUnit = Cm | Inch | Mile
type Name = 
    | Nickname of string
    | FirstLast of string * string
type Tree<'a> = 
    | E
    | T of Tree<'a> * 'a * Tree<'a>
    
type BST<'T> =
    | Empty
    | Node of 'T * BST<'T> * BST<'T> // Каждый узел имеет левый и правый BST<'T>

let rec flip bst =
    match bst with
    | Empty -> bst
    | Node(item, left, right) -> Node(item, flip right, flip left)
    
//usage 
let tree = 
    Node(10, 
        Node(3, 
            Empty, 
            Node(6, 
                Empty, 
                Empty)),
        Node(55,
            Node(16, 
                Empty,
                Empty),
            Empty))
            
let runDU = 
    printfn "%A" (flip tree)
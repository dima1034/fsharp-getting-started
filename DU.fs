module DU

// type defined a set of choises 
// DU = is sum of it is cases

// "SUM" types 

type MeasurementUnit = Cm | Inch | Mile
type Name = 
    | Nickname of string
    | FirstLast of string * string
type Tree<'a> = 
    | E
    | T of Tree<'a> * 'a * Tree<'a>
    
//usage 

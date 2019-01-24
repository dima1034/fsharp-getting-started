module CSharpInterop

open CSharpLibrary

type Consumer() =
    let c1 = new Numbers()
    member this.number = c1.Getnumber()
    
    interface ICanAddNumber with
        member this.Add (a, b) = a + b


// F# gives posibility to implement inerfaces without creating an class itself
let objectWithAddMethod = {new ICanAddNumber
            with member this.Add (a,b) = a + b}




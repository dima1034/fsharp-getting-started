module record 

//used curly braces and semicolons to separate fields
type Message<'a> = { id: int; body: 'a }

//usage
let m: Message<string> = { id=1; body="hello" }
let m2 = { id=1; body=2 }
let m3 = { id=2; body=Some }
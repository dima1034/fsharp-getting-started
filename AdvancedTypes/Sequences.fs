module AdvancedTypes.Sequences

seq {2..4..6}

let runSeq() = seq {for i in {0..10..100} -> i} |> printfn "%A"
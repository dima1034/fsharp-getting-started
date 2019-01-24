module DisposableComponents

open System.IO

let readAFile () =
        //take a look at the use keyword
        use reader = new StreamReader(
                        __SOURCE_DIRECTORY__ + "/text.txt")
        reader.ReadToEnd()
        
readAFile() |> printf "%A"

// - unmanaged resorces are operating system resources that .net cannot clean up
// - clean up of unmanaged resources relies on programmer discipline
// - disposable components implements the IDisposable interface
// - F# has the "use" keyword for controlling component disposal

        

